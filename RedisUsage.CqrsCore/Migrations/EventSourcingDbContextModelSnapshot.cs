﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedisUsage.CqrsCore.CqrsRepository;

namespace RedisUsage.CqrsCore.Migrations
{
    [DbContext(typeof(EventSourcingDbContext))]
    partial class EventSourcingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedisUsage.CqrsCore.CqrsRepository.EventSourcingDescription", b =>
                {
                    b.Property<Guid>("EsdId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<string>("AggregateType");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EventData");

                    b.Property<string>("EventType");

                    b.Property<long>("Version");

                    b.HasKey("EsdId");

                    b.ToTable("EventSourcingDescription");
                });
#pragma warning restore 612, 618
        }
    }
}