using CvBackendTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CvBackendTest.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<CvEntry> CvEntries => Set<CvEntry>();
}