using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aurochses.Data;
using AutoMapper;
using InTouch.Business.Chat.Dto;
using InTouch.Business.Chat.Interfaces;
using InTouch.Data.Chat;
using InTouch.Data.Chat.Entities;

namespace InTouch.Business.Chat.Services
{
    public class PersonService : IPersonService
    {
        private readonly IChatUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PersonService(IChatUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<PersonDto>> GetListAsync()
        {
            var entities = await _unitOfWork.PersonRepository.GetListAsync();

            return _mapper.Map<IList<PersonDto>>(entities);
        }

        public async Task<PersonDto> GetAsync(int id)
        {
            var entity = await _unitOfWork.PersonRepository.GetAsync(x => x.Id == id);

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task<PersonDto> CreateAsync(PersonDto model)
        {
            var entity = await _unitOfWork.PersonRepository.InsertAsync(_mapper.Map<PersonEntity>(model));
            _unitOfWork.Commit();

            return _mapper.Map<PersonDto>(entity);
        }

        public PersonDto UpdateAsync(PersonDto model)
        {
            var entity = _unitOfWork.PersonRepository.Update(_mapper.Map<PersonEntity>(model));
            _unitOfWork.Commit();

            return _mapper.Map<PersonDto>(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                var entityToDelete = await _unitOfWork.PersonRepository.GetAsync(x => x.Id == id);
                if (entityToDelete == null)
                {
                    throw new Exception("Person doesn't exist");
                }
                _unitOfWork.PersonRepository.Delete(entityToDelete);
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
