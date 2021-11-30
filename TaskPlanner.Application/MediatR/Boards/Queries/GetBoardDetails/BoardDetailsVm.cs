using AutoMapper;
using System;
using System.Collections.Generic;
using TaskPlanner.Application.Common.Mapping;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardDetails
{
    class BoardDetailsVm : IMapWith<Board>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<Card> Cards { get; set; }
        public List<TaskPlannerUser> Users { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Board, BoardDetailsVm>()
                .ForMember(boardVm => boardVm.Id, opt => opt.MapFrom(board => board.Id))
                .ForMember(boardVm => boardVm.Title, opt => opt.MapFrom(board => board.Title))
                .ForMember(boardVm => boardVm.Details, opt => opt.MapFrom(board => board.Details))
                .ForMember(boardVm => boardVm.CreatedOn, opt => opt.MapFrom(board => board.CreatedOn))
                .ForMember(boardVm => boardVm.UpdatedOn, opt => opt.MapFrom(board => board.UpdatedOn))
                .ForMember(boardVm => boardVm.IsPrivate, opt => opt.MapFrom(board => board.IsPrivate))
                .ForMember(boardVm => boardVm.Cards, opt => opt.MapFrom(board => board.Cards))
                .ForMember(boardVm => boardVm.Users, opt => opt.MapFrom(board => board.Users));
        }

    }
}