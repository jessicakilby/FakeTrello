using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTrello.DAL
{
    interface IRepository
    {
        // List of methods to help deliver features
        // Create
        void AddBoard(string name, ApplicationUser owner);
        void AddList(string name, Board board);
        void AddList(string name, int boardId);
        void AddCard(string name, List list, ApplicationUser owner);
        void AddCard(string name, int listId, string ownerId);

        //Read
        List<Card> GetCardsFromLSist(int listId);
        List<Card> GetCardsFromBoard(int boardId);
        Card GetCard(int cardId);
        List GetList(int listId);
        List<List> GetListsFromBoard(int boardId); // List of Trello Lists
        List<Board> GetBoardsFromUser(int userId);
        Board GetBoard(int boardid);
        List<ApplicationUser> GetCardAttendees(int cardId);

        //Udate
        bool AttachUser(int userId, int cardId); //true: successful, false: not successful
        bool MoveCard(int cardId, int oldListId, int newListId);
        bool CopyCard(int cardId, int newListId, int newOwnerId);

        //Delete
        bool RemoveBoard(int boardId);
        bool RemoveList(int listId);
        bool RemoveCard(int cardId);
    }
}
