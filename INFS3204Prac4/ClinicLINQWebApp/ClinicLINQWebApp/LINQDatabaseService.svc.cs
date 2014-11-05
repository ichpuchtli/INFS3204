using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClinicLINQWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LINQDatabaseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LINQDatabaseService.svc or LINQDatabaseService.svc.cs at the Solution Explorer and start debugging.
    public class LINQDatabaseService : ILINQDatabaseService
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public bool PlayerRegistration(Player player)
        {
            try
            {
                db.Players.InsertOnSubmit(player);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                throw new FaultException();
            }
        }

        public bool ClubRegistration(Club club)
        {
            try
            {
                db.Clubs.InsertOnSubmit(club);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                throw new FaultException();
            }
        }

        public Player GetPlayerInfo(string firstname, string lastname)
        {

            var player = db.Players.Where(x => x.FirstName == firstname && x.LastName == lastname).FirstOrDefault();

            if(player == null)
            {
                throw new FaultException("Not Found");
            }
            else
            {
                return player;
            }

        }

        public Club GetClubInfo(string name)
        {


            var club = db.Clubs.Where(x => x.Name == name).FirstOrDefault();

            if (club == null)
            {
                throw new FaultException();
            }
            else
            {
                return club;
            }
        }

        public bool NewMembership(string fullname, string clubname, DateTime startdate)
        {
            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);

            var membership = new Membership()
            {
                MembershipID = Guid.NewGuid().ToString(),
                ClubID = club.RegistrationID,
                PlayerID = player.RegistrationID,
                StartDate = startdate
            };

            try
            {
                db.Memberships.InsertOnSubmit(membership);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                throw new FaultException();
            }
        }

        public Membership GetMembership(string fullname, string clubname)
        {

            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);
            var membership = db.Memberships.Where(x => x.ClubID == club.RegistrationID && x.PlayerID == player.RegistrationID).FirstOrDefault();

            if (membership == null)
            {
                throw new FaultException();
            }

            return membership;

        }

        public bool UpdateMembership(string fullname, string clubname, DateTime enddate, int gamesplayed)
        {
            var firstname = fullname.Split(new char[]{' '})[0];
            var lastname = fullname.Split(new char[]{' '})[1];

            Player player = GetPlayerInfo(firstname, lastname);

            Club club = GetClubInfo(clubname);

            var membership = db.Memberships.Where(x => x.ClubID == club.RegistrationID && x.PlayerID == player.RegistrationID).FirstOrDefault();

            if (membership == null)
            {
                throw new FaultException();
            }

            membership.EndDate = enddate;
            membership.NumOfGames = gamesplayed;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                throw new FaultException();
            }
        }
    }
}
