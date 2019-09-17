using ProfloPortalBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfloPortalBackend.BusinessLayer
{
     public interface ITeamService
    {
        List<Team> GetTeams();
        bool UpdateTeam(string teamId, Team team);
        Team GetTeamByID(string teamID);
        void CreateTeam(Team team);
        bool RemoveTeamById(string teamId);
        void createMembers(string teamId, Member member);
        bool UpdateMembers(string teamId, string mid, Member member);
        bool RemoveMembers(string teamID, string mID);
        //void createInvite(int teamID, Invitee invite);
        //bool UpdateInvite(int teamId, int inviteID, Invitee invite);
        //ICollection<Invitee> getTeamInvites(int teamID);
        ICollection<Member> GetTeamMembers(string teamID);
        //bool RemoveInvite(int teamId, int inviteID);


        ICollection<TeamBoard> getTeamBoards(string teamID);

        Member GetMemberByMemberId(string teamId, string memberId);

    }
}
