using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aurochses.Data;
using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Business.Chat.Interfaces;
using InTouch.Data.Chat;
using InTouch.Data.Chat.Entities;
using InTouch.Data.Chat.Enums;

namespace InTouch.Business.Chat.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChatService(IChatUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<ChatDto>> GetListAsync(int personId)
        {
            var entities = await _unitOfWork.ChatRepository.GetListAsync(x => x.PersonChats.Any(y => y.PersonId == personId));

            return _mapper.Map<IList<ChatDto>>(entities);
        }

        public async Task<ChatDto> GetAsync(int id)
        {
            var entity = await _unitOfWork.ChatRepository.GetAsync(x => x.Id == id);

            return _mapper.Map<ChatDto>(entity);
        }

        public async Task<ChatDto> CreateAsync(int currentPersonId, ChatDto model)
        {
            try
            {

                //var person = await _unitOfWork.PersonRepository.GetAsync(x => x.Id == currentPersonId);
                //var entityToCreate = _mapper.Map<ChatEntity>(model);
                //entityToCreate. = person ?? throw new Exception("Current person doesn't exist");
                ////var createdEntity = await _unitOfWork.ChatRepository.InsertAsync(entityToCreate);
                //await _unitOfWork.PersonRepository.InsertAsync(new PersonEntity
                //    {FirstName = "sd", LastName = "saaaaa", Photo = "asdas", Status = PersonStatus.Offline});
                //await _unitOfWork.CommitAsync();
                return _mapper.Map<ChatDto>(new ChatEntity());

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ChatDto UpdateAsync(ChatDto model)
        {
            try
            {
                var entityToUpdate = _mapper.Map<ChatEntity>(model);
                var updatedEntity = _unitOfWork.ChatRepository.Update(entityToUpdate);
                _unitOfWork.Commit();

                return _mapper.Map<ChatDto>(updatedEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                var entityToDelete = await _unitOfWork.ChatRepository.GetAsync(x => x.Id == id);
                if (entityToDelete == null)
                {
                    throw new Exception("Chat doesn't exist");
                }
                _unitOfWork.ChatRepository.Delete(entityToDelete);
                await _unitOfWork.CommitAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
