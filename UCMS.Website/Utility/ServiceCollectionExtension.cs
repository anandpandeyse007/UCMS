using UCMS.Website.Services;

namespace UCMS.Website.Utility
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDependecyInjectionServices(this IServiceCollection services)
        {
            // Register your custom service here
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IAnnouncementService, AnnouncementService>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();

            return services;
        }
    }
}
