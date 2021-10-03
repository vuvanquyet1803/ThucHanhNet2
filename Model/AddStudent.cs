using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Models;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class AddStudent
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        StudentId = 1,
                        StudentName = "Vũ Văn Quyết"
                    },
                    new Student
                    {
                        StudentId = 2,
                        StudentName = "Vũ Văn Lâm"
                    },
                    new Student
                    {
                        StudentId = 3,
                        StudentName = "Vũ Văn Long"
                    },
                    new Student
                    {
                        StudentId = 4,
                        StudentName = "Vũ Văn Quân"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}