using ProfloPortalBackend.DataAccessLayer;
using ProfloPortalBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfloPortalBackend.BusinessLayer
{
    public class CardService : ICardService
    {
        public readonly ICardRepository cardRepository;
        public CardService(ICardRepository cardRepository)
        {
            this.cardRepository = cardRepository;
        }


        #region Card Operation
        public void CreateCard(Card card)
        {
            if (card.Assignees == null)
            {
                card.Assignees = new List<Member>();
            }
            if (card.Labels == null)
            {
                card.Labels = new List<Label>();
            }
            if (card.Attachments == null)
            {
                card.Attachments = new List<Attachment>();
            }
            if (card.Comments == null)
            {
                card.Comments = new List<Comment>();
            }
            if (card.CardInvites == null)
            {
                card.CardInvites = new List<Invitee>();
            }

            cardRepository.CreateCard(card);
        }
        public Card GetCardByID(string cardId)
        {
            var result = cardRepository.GetCardByID(cardId);
            return result;
        }

        public List<Card> GetCards()
        {
            return cardRepository.GetCards();
        }
        public bool UpdateCard(string cardId, Card card)
        {
            return cardRepository.UpdateCard(cardId, card);
        }
        public bool RemoveCard(string cardId)
        {
            return cardRepository.RemoveCard(cardId);
        }
        #endregion

        #region Card Members
        public void CreateCardMembers(string cardId, Member member)
        {

            cardRepository.CreateCardMembers(cardId, member);
        }
        public ICollection<Member> GetCardMembers(string cardID)
        {
            return cardRepository.GetCardMembers(cardID);
        }
        public Member GetMemberByMemberId(string cardId, string memberId)
        {
            return cardRepository.GetMemberByMemberId(cardId, memberId);
        }

        public bool UpdateCardMembers(string cardId, string memberID, Member member)
        {
            return cardRepository.UpdateCardMembers(cardId, memberID, member);
        }    
        public bool RemoveMembers(string cardId, string Mid)
        {
            return cardRepository.RemoveMembers(cardId, Mid);
        }
        #endregion

        #region Card Invitee

        public void CreateInvite(string cardID, Invitee invite)
        {
            cardRepository.CreateInvite(cardID, invite);
        }
        public ICollection<Invitee> GetCardInvites(string cardID)
        {
            return cardRepository.GetCardInvites(cardID);
        }
        //public bool UpdateInvite(string cardId, string inviteID, Invitee invite)
        //{
        //    return cardRepository.UpdateInvite(cardId, inviteID, invite);
        //}
        public bool RemoveInvite(string cardId, string inviteID)
        {
            return cardRepository.RemoveInvite(cardId, inviteID);
        }
        #endregion

        #region Card Label
        public void CreateLabel(string cardID, Label label)
        {
            cardRepository.CreateLabel(cardID, label);
        }
        public ICollection<Label> GetCardLabels(string cardID)
        {
            return cardRepository.GetCardLabels(cardID);
        }

        public bool UpdateLabel(string cardID, string labelID, Label label)
        {
            return cardRepository.UpdateLabel(cardID, labelID, label);
        }

        public bool RemoveLabel(string cardId, string labelID)
        {
            return cardRepository.RemoveLabel(cardId, labelID);
        }

        public Label GetLabelByID(string cardId, string labelID)
        {
            return cardRepository.GetLabelByID(cardId, labelID);
        }
        #endregion

        #region Card Comments

        public void CreateComments(string cardId, Comment comments)
        {
            cardRepository.CreateComments(cardId, comments);
        }
        public Comment GetCommentByID(string cardId, string commentID)
        {
            return cardRepository.GetCommentByID(cardId, commentID);
        }

        public ICollection<Comment> GetComments(string cardID)
        {
            return cardRepository.GetComments(cardID);
        }

        public bool UpdateComments(string cardID, string commentID, Comment comments)
        {
            return cardRepository.UpdateComments(cardID, commentID, comments);
        }

        public bool RemoveComments(string cardId, string commentID)
        {
            return cardRepository.RemoveComments(cardId, commentID);
        }
        #endregion

        #region Card Attachment

        public void CreateAttachment(string cardID, Attachment attachement)
        {
            cardRepository.CreateAttachment(cardID, attachement);
        }

        public Attachment GetAttachmentByID(string cardId, string attachmentID)
        {
            return cardRepository.GetAttachmentByID(cardId, attachmentID);
        }

        public ICollection<Attachment> GetAttachment(string cardID)
        {
            return cardRepository.GetAttachment(cardID);
        }

        public bool UpdateAttachment(string cardID, string attachmentID, Attachment attachement)
        {
            return cardRepository.UpdateAttachment(cardID, attachmentID, attachement);
        }

        public bool RemoveAttachment(string cardId, string attachmentID)
        {
            return cardRepository.RemoveAttachment(cardId, attachmentID);
        }
        #endregion
    }
}
