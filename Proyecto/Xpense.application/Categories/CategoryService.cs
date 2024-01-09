﻿using Xpense.application.Categories.Interfaces;
using Xpense.application.Categories.Models;
using Xpense.domain.Categories;
using Xpense.infrastructure.Repositories.Categories.Interfaces;

namespace Xpense.application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoriesRepository;
        public CategoryService(ICategoryRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }
        public async Task<CategoryReadDto> Create(CategoryCreateDto category)
        {
            var entity = new Category
            {
                Nombre = category.Nombre,
                UsuarioId = category.UsuarioId
            };
            entity = await _categoriesRepository.Create(entity);
            var mappedEntity = new CategoryReadDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                UsuarioId = entity.UsuarioId
            };
            return mappedEntity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _categoriesRepository.Delete(id);
            return result;
        }

        public async Task<CategoryReadDto> Get(int id)
        {
            var entity = await _categoriesRepository.Get(id);
            var mappedEntity = new CategoryReadDto
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                UsuarioId = entity.UsuarioId
            };
            return mappedEntity;
        }

        public async Task<ICollection<CategoryReadDto>> GetAll()
        {
            var entities = await _categoriesRepository.GetAll();
            return entities.Select(x => new CategoryReadDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                UsuarioId = x.UsuarioId
            }).ToList();
        }

        public async Task<CategoryReadDto> Update(CategoryReadDto category)
        {
            var entityToUpdate = await _categoriesRepository.Get(category.Id);


            entityToUpdate.Id = category.Id;
            entityToUpdate.Nombre = category.Nombre;
            entityToUpdate.UsuarioId = category.UsuarioId;

            entityToUpdate = await _categoriesRepository.Update(entityToUpdate);
            var mappedEntity = new CategoryReadDto
            {
                Id = entityToUpdate.Id,
                Nombre = entityToUpdate.Nombre,
                UsuarioId = entityToUpdate.UsuarioId
            };
            return mappedEntity;
        }
    }
}
