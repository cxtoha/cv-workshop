﻿using backend.Data.Models;

namespace backend.Services;

public interface ICvService
{
    // Users
    Task<IEnumerable<User>> GetAllUsersAsync();

    Task<User?> GetUserByIdAsync(Guid id);

    Task<IEnumerable<User>> GetUsersWithDesiredSkills(IEnumerable<string> desiredTechnologies);

    // Experiences
    Task<IEnumerable<Experience>> GetAllExperiencesAsync();
    Task<Experience?> GetExperienceByIdAsync(Guid id);
    Task<IEnumerable<Experience>> GetExperiencesByTypeAsync(string type);
}
