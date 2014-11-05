using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.Services.Protocols;

namespace ClinicWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ADODatabaseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ADODatabaseService.svc or ADODatabaseService.svc.cs at the Solution Explorer and start debugging.
    public class ADODatabaseService : IADODatabaseService
    {
        public static string DataSource = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\sam\\src\\INFS3204Prac4\\ClinicWebApp\\ClinicWebApp\\App_Data\\Database.mdf;Integrated Security=True;MultipleActiveResultSets=True";

        public bool PlayerRegistration(Player player)
        {
            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = 
                    "insert into dbo.Player " + 
                    "(RegistrationID, FirstName, LastName, PhoneNumber, Address, DateOfBirth) values " +
                    "(@RegistrationID, @FirstName, @LastName, @PhoneNumber, @Address, @DateOfBirth)";

                SqlCommand cmd = new SqlCommand(statement,conn);

                cmd.Parameters.Add(new SqlParameter("@RegistrationID", player.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@FirstName", player.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", player.LastName));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", player.PhoneNumber.HasValue ? player.PhoneNumber.Value : (object) DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@Address", player.Address));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", player.DateOfBirth));

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    throw new FaultException();
                }   
            }
        }

        public bool ClubRegistration(Club club)
        {
            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = 
                    "insert into dbo.Club " + 
                    "(RegistrationID, Name, Founded, WorldRanking) values " +
                    "(@RegistrationID, @Name, @Founded, @WorldRanking)";

                SqlCommand cmd = new SqlCommand(statement,conn);

                cmd.Parameters.Add(new SqlParameter("@RegistrationID", club.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@Name", club.Name));
                cmd.Parameters.Add(new SqlParameter("@Founded", club.Founded));
                cmd.Parameters.Add(new SqlParameter("@WorldRanking", club.WorldRanking.HasValue ? club.WorldRanking.Value : (object) DBNull.Value));

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    throw new FaultException();
                }   
            }
        }

        public Player GetPlayerInfo(string firstname, string lastname)
        {
            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = "select * from dbo.Player where FirstName = @FirstName and LastName = @LastName"; 

                SqlCommand cmd = new SqlCommand(statement, conn);

                cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                cmd.Parameters.Add(new SqlParameter("@LastName", lastname));

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    return new Player()
                    {
                        RegistrationID = reader["RegistrationID"].ToString(),
                        FirstName = firstname,
                        LastName = lastname,
                        PhoneNumber = !reader.IsDBNull(3) ? Int32.Parse(reader["PhoneNumber"].ToString()) : new Nullable<Int32>(),
                        Address = reader["Address"].ToString(),
                        DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString())
                    };

                }

                throw new FaultException("Not Found");
            }
        }

        public Club GetClubInfo(string name)
        {
            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = "select * from dbo.Club where Name = @Name";

                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", name));

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    return new Club()
                    {
                        RegistrationID = reader["RegistrationID"].ToString(),
                        Name = name,
                        Founded = DateTime.Parse(reader["Founded"].ToString()),
                        WorldRanking = !reader.IsDBNull(3) ? Int32.Parse(reader["WorldRanking"].ToString()) : new Nullable<Int32>()
                    };
                }

                throw new FaultException();

            }
        }

        public bool NewMembership(string fullname, string clubname, DateTime startdate)
        {
            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);

            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement =
                    "insert into dbo.Membership " +
                    "(MembershipID, ClubID, PlayerID, StartDate) values " +
                    "(@MembershipID, @ClubID, @PlayerID, @StartDate)";

                SqlCommand cmd = new SqlCommand(statement, conn);

                cmd.Parameters.Add(new SqlParameter("@MembershipID", Guid.NewGuid().ToString()));
                cmd.Parameters.Add(new SqlParameter("@ClubID", club.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@PlayerID", player.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@StartDate", startdate));

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    throw new FaultException();
                }
            }
        }

        public Membership GetMembership(string fullname, string clubname)
        {

            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);

            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = "select * from dbo.Membership where ClubID = @ClubID and PlayerID = @PlayerID";

                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add(new SqlParameter("@ClubID", club.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@PlayerID", player.RegistrationID));

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    return new Membership()
                    {
                        MembershipID = reader["MembershipID"].ToString(),
                        ClubID = club.RegistrationID,
                        PlayerID = player.RegistrationID,
                        StartDate = DateTime.Parse(reader["StartDate"].ToString()),
                        EndDate = !reader.IsDBNull(4) ? DateTime.Parse(reader["EndDate"].ToString()) : new Nullable<DateTime>(),
                        NumOfGames = !reader.IsDBNull(5) ? Int32.Parse(reader["NumOfGames"].ToString()) : new Nullable<Int32>()
                    };
                }

                throw new FaultException();

            }

        }

        public bool UpdateMembership(string fullname, string clubname, DateTime enddate, int gamesplayed)
        {
            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);

            using (SqlConnection conn = new SqlConnection(DataSource))
            {
                conn.Open();

                string statement = "update dbo.Membership set EndDate = @EndDate, NumOfGames = @NumOfGames where ClubID = @ClubID and PlayerID = @PlayerID";

                SqlCommand cmd = new SqlCommand(statement, conn);
                cmd.Parameters.Add(new SqlParameter("@EndDate", enddate));
                cmd.Parameters.Add(new SqlParameter("@NumOfGames", gamesplayed));
                cmd.Parameters.Add(new SqlParameter("@ClubID", club.RegistrationID));
                cmd.Parameters.Add(new SqlParameter("@PlayerID", player.RegistrationID));

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    throw new FaultException();
                }
            }
        }
    }
}
