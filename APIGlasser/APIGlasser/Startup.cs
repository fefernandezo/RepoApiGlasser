﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGlasser.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace APIGlasser
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<PlabalDBContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("PlabalConnectionString")));
            services.AddDbContext<PlabalDBContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("RandomConnectionString")));
            services.AddDbContext<PlabalDBContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("AlfakConnectionString")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
