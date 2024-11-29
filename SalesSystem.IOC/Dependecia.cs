using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesSystem.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SalesSystem.DAL.Interfaces;
//using SalesSystem.DAL.Implementacio;
//using SalesSystem.BBL.Interfaces;
//using SalesSystem.BBL.Implementacio;

namespace SalesSystem.IOC {
	public static class Dependecia {	
		public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration) {
			services.AddDbContext<DbSalesContext>(options => {
				options.UseSqlServer(configuration.GetConnectionString("CadenaSql"));
			});
		}
	}
}
