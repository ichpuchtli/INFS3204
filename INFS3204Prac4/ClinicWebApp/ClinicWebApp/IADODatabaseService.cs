using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClinicWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IADODatabaseService" in both code and config file together.
    [ServiceContract]
    public interface IADODatabaseService
    {
        [OperationContract]
        Boolean PlayerRegistration(Player player);

        [OperationContract]
        Boolean ClubRegistration(Club club);

        [FaultContract(typeof(FaultException))]
        [OperationContract]
        Player GetPlayerInfo(String firstname, String lastname);

        [OperationContract]
        Club GetClubInfo(String name);

        [OperationContract]
        Boolean NewMembership(String fullname, String clubname, DateTime startdate);

        [OperationContract]
        Membership GetMembership(String fullname, String clubname);

        [OperationContract]
        Boolean UpdateMembership(String fullname, String clubname, DateTime enddate, int gamesplayed);
    }

    [DataContract]
    public class Player
    {
        [DataMember]
        public String RegistrationID {get; set;}

        [DataMember]
        public String FirstName {get; set;}

        [DataMember]
        public String LastName {get; set;}

        [DataMember]
        public Nullable<Int32> PhoneNumber {get; set;}

        [DataMember]
        public String Address {get; set;}

        [DataMember]
        public DateTime DateOfBirth {get; set;}

        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }

    [DataContract]
    public class Club
    {
        [DataMember]
        public String RegistrationID {get; set;}

        [DataMember]
        public String Name {get; set;}

        [DataMember]
        public DateTime Founded {get; set;}

        [DataMember]
        public Nullable<Int32> WorldRanking {get; set;}
    }

    [DataContract]
    public class Membership
    {
        [DataMember]
        public String MembershipID {get; set;}

        [DataMember]
        public String PlayerID {get; set;}

        [DataMember]
        public String ClubID {get; set;}

        [DataMember]
        public DateTime StartDate {get; set;}

        [DataMember]
        public Nullable<DateTime> EndDate {get; set;}

        [DataMember]
        public Nullable<Int32> NumOfGames {get; set;}

    }


}
