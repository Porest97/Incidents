using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Incidents.Models.DataModels;
using Incidents.Models.SettingsModels;

namespace Incidents.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Incidents.Models.DataModels.Company> Company { get; set; }
        public DbSet<Incidents.Models.DataModels.Person> Person { get; set; }
        public DbSet<Incidents.Models.SettingsModels.CompanyRole> CompanyRole { get; set; }
        public DbSet<Incidents.Models.SettingsModels.CompanyStatus> CompanyStatus { get; set; }
        public DbSet<Incidents.Models.SettingsModels.CompanyType> CompanyType { get; set; }
        public DbSet<Incidents.Models.SettingsModels.PersonRole> PersonRole { get; set; }
        public DbSet<Incidents.Models.SettingsModels.PersonStatus> PersonStatus { get; set; }
        public DbSet<Incidents.Models.SettingsModels.PersonType> PersonType { get; set; }
        public DbSet<Incidents.Models.DataModels.Site> Site { get; set; }
        public DbSet<Incidents.Models.SettingsModels.SiteRole> SiteRole { get; set; }
        public DbSet<Incidents.Models.SettingsModels.SiteStatus> SiteStatus { get; set; }
        public DbSet<Incidents.Models.SettingsModels.SiteType> SiteType { get; set; }
        public DbSet<Incidents.Models.SettingsModels.IncidentPriority> IncidentPriority { get; set; }
        public DbSet<Incidents.Models.SettingsModels.IncidentStatus> IncidentStatus { get; set; }
        public DbSet<Incidents.Models.SettingsModels.IncidentType> IncidentType { get; set; }
        public DbSet<Incidents.Models.DataModels.Incident> Incident { get; set; }
        public DbSet<Incidents.Models.DataModels.PurchaseOrder> PurchaseOrder { get; set; }

    }
}
