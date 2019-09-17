using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfloPortalBackend.DataAccessLayer;
using ProfloPortalBackend.Model;

namespace ProfloPortalBackend.BusinessLayer
{
    public class BoardService : IBoardService
    {
        public readonly IBoardRepository boardRepository;
        public BoardService (IBoardRepository boardRepository)
        {
            this.boardRepository = boardRepository;
        }

        #region Board Operations
        public async Task<Board> CreateBoard(Board board)
        {
            if (board.BoardMembers == null)
            {
                board.BoardMembers = new List<Member>();
            }
            if (board.BoardInvites == null)
            {
                board.BoardInvites = new List<Invitee>();
            }
            if (board.BoardLists == null)
            {
                board.BoardLists = new List<List>();
            }

            return await boardRepository.CreateBoard(board);
        }
        public List<Board> GetBoards()
        {
            return boardRepository.GetBoards();
        }
        public Board GetBoardById(string boardId)
        {
            var result = boardRepository.GetBoardById(boardId);
            return result;
        }
        public bool UpdateBoard(string boardId, Board board)
        {
            Board board1 = new Board();
            if (board.BoardMembers == null)
            {
                board.BoardMembers = board1.BoardMembers;
            }
            if (board.BoardInvites == null)
            {
                board.BoardInvites = board1.BoardInvites;
            }
            if (board.BoardLists == null)
            {
                board.BoardLists = board1.BoardLists;
            }
            return boardRepository.UpdateBoard(boardId, board);
        }
        public bool RemoveBoard(string boardId)
        {
            return boardRepository.RemoveBoard(boardId);
        }
        #endregion


        #region BoardMembers
        public void CreateMembers(string boardId, Member member)
        {
            boardRepository.CreateMembers(boardId, member);
        }
        public ICollection<Member> GetBoardMembers(string boardId)
        {
            return boardRepository.GetBoardMembers(boardId);
        }
        public Member GetMemberByMemberId(string boardId, string memberId)
        {
            return boardRepository.GetMemberByMemberId(boardId, memberId);
        }
        public bool UpdateMembers(string boardId, string Mid, Member member)
        {
            return boardRepository.UpdateMembers(boardId, Mid, member);
        }
        public bool RemoveMembers(string boardId, string MId)
        {
            return boardRepository.RemoveMembers(boardId, MId);
        }
        #endregion


        #region BoardInvitee
        public void CreateInvite(string boardId, Invitee invite)
        {
            boardRepository.CreateInvite(boardId, invite);
        }
        public ICollection<Invitee> GetBoardInvites(string boardId)
        {
            return boardRepository.GetBoardInvites(boardId);
        }
        public bool UpdateInvite(string boardId, string inviteId, Invitee invite)
        {
            return boardRepository.UpdateInvite(boardId, inviteId, invite);
        }
        public bool RemoveInvite(string boardId, string inviteId)
        {
            return boardRepository.RemoveInvite(boardId, inviteId);
        }
        #endregion
        public ICollection<List> GetLists(string boardId)
        {
            return boardRepository.GetLists(boardId);
        }
    }
}
