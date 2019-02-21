﻿/*
 * Copyright (c) 2017-2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Piranha.Data;

namespace Piranha.Repositories
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Gets all available models.
        /// </summary>
        /// <param name="blogId">The blog id</param>
        /// <returns>The available models</returns>
        Task<IEnumerable<Category>> GetAll(Guid blogId);

        /// <summary>
        /// Gets the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        /// <returns>The model, or NULL if it doesn't exist</returns>
        Task<Category> GetById(Guid id);

        /// <summary>
        /// Gets the model with the given slug
        /// </summary>
        /// <param name="blogId">The blog id</param>
        /// <param name="slug">The unique slug</param>
        /// <returns>The model</returns>
        Task<Category> GetBySlug(Guid blogId, string slug);

        /// <summary>
        /// Gets the model with the given title
        /// </summary>
        /// <param name="blogId">The blog id</param>
        /// <param name="title">The unique title</param>
        /// <returns>The model</returns>
        Task<Category> GetByTitle(Guid blogId, string title);

        /// <summary>
        /// Adds or updates the given model in the database
        /// depending on its state.
        /// </summary>
        /// <param name="model">The model</param>
        Task Save(Category model);

        /// <summary>
        /// Deletes the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        Task Delete(Guid id);

        /// <summary>
        /// Deletes all unused categories for the specified blog.
        /// </summary>
        /// <param name="blogId">The blog id</param>
        Task DeleteUnused(Guid blogId);
    }
}
