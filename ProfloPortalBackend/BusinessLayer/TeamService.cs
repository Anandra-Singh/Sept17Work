using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfloPortalBackend.DataAccessLayer;
using ProfloPortalBackend.Model;

namespace ProfloPortalBackend.BusinessLayer
{
    public class TeamService : ITeamService
    {
        public readonly ITeamRepository teamRepository;
        public TeamService(ITeamRepository teamInterface)
        {
            this.teamRepository = teamInterface;
        }
        public void createInvite(int teamID, Invitee invite)
        {
            throw new NotImplementedException();
        }

        public void createMembers(string teamId, Member member)
        {
            //var teamMembers = new Member()
            //{
            //    MemberId = member.MemberId,
            //    MemberName = member.MemberName,
            //    Status = member.Status
            //};
            teamRepository.CreateMembers(teamId, member);
        }

        public void CreateTeam(Team team)
        {
            if (team.TeamMembers == null)
            {
                team.TeamMembers = new List<Member>();
            }
            teamRepository.CreateTeam(team);
            //var result = ITeamRepository.GetTeamByID(team.TeamId);
            //if (result == null)
            //{
            //    //if(team.TeamBoards==null)
            //    //{
            //    //    team.TeamBoards = new List<TeamBoard>();
            //    //}
            //    //else if(team.TeamMembers==null)
            //    //{
            //    //    team.TeamMembers = new List<Member>();
            //    //}
            //    //else if(team.TeamInvites==null)
            //    //{
            //    //    team.TeamInvites = new List<Invitee>();
            //    //}
            //    ITeamRepository.CreateTeam(team);
            //}
            //else
            //{
            //    //throw new TeamAlraedyExistsException("The Team Already Exists in Database ")
            //}
        }

        public ICollection<TeamBoard> getTeamBoards(string teamID)
        {
            return teamRepository.getTeamBoards(teamID);
        }

        public Team GetTeamByID(string teamID)
        {
            var result = teamRepository.GetTeamByID(teamID);
            return result;
        }

        //public ICollection<Invitee> getTeamInvites(int teamID)
        //{
        //    throw new NotImplementedException();
        //}

        public ICollection<Member> GetTeamMembers(string teamID)
        {
            return teamRepository.GetTeamMembers(teamID);
        }

        public Member GetMemberByMemberId(string teamId, string memberId)
        {
            return teamRepository.GetMemberByMemberId(teamId, memberId);
        }
        public List<Team> GetTeams()
        {
            return teamRepository.GetTeams();
        }

        //    public bool RemoveInvite(int teamId, int inviteID)
        //    {
        //        throw new NotImplementedException();
        //    }

        public bool RemoveMembers(string teamID, string mID)
        {
            return teamRepository.RemoveMembers(teamID, mID);
        }

        public bool RemoveTeamById(string teamId)
        {
            return teamRepository.RemoveTeam(teamId);
        }

        public bool UpdateMembers(string teamId, string mid, Member member)
        {
            return teamRepository.UpdateMembers(teamId, mid, member);
        }

        //    public bool UpdateInvite(int teamId, int inviteID, Invitee invite)
        //    {
        //        throw new NotImplementedException();
        //    }

        public bool UpdateTeam(string teamId, Team team)
        {
            return teamRepository.UpdateTeam(teamId, team);
        }
    }
    }
