using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClinicLINQWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILINQDatabaseService" in both code and config file together.
    [ServiceContract]
    public interface ILINQDatabaseService 
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
}
