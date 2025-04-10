using Resume_NicolasCastillo_Backend.Entities;
using System;
using System.Xml.Linq;

namespace Resume_NicolasCastillo_Backend.Data
{
    public static class DataGenerator
    {
        public static void Seed()
        {
            var db = InMemoryDb.Instance;

            var person = new Person
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Title = "Developer FullStack (.Net/Angular)",
                Name = "Nicolás Ezequiel",
                Surname = "Castillo",
                GitHub = "https://github.com/Nicoecas/Resume_NicolasCastillo_Backend",
                Phone = "------------",
                LinkedIn = "https://www.linkedin.com/in/nicolasezcastillo/",
                Email = "nicoecas.96@gmail.com",
                Address = "Monte Grande, Provincia de Buenos Aires",
                BirthDate = new DateTime(1996, 05, 28),
                DescriptionCard = $"Soy desarrollador de software, con más de 3 años de experiencia en el mercado. Me considero una persona proactiva" +
                    $" y apasionada, que ha transformado su vocación en una carrera profesional gracias a años de esfuerzo y dedicación." +
                    $"\r\n" +
                    $"\r\n" +
                    $"\r\n" +
                    $"Comprometido con el aprendizaje constante, valoro la comunicación clara para superar expectativas y lograr resultados eficientes." +
                    $" Me entusiasman los desafíos y siempre busco soluciones, asegurándome de estar mejor preparado para responder de manera excepcional" +
                    $" en cada oportunidad.",

                Certifications = new List<Certification>
                    {
                        new Certification
                        {
                            Id = 1,
                            PersonId = 1,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            Name = "Alkemy Labs Aceleración C#",
                            Institution = "Alkemy",
                            Year = 2022,
                        }
                    },

                Educations = new List<Education>
                    {
                        new Education
                        {
                            Id = 1,
                            PersonId = 1,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            Degree = "Técnico Electromecánico",
                            Institution = "Instituto Técnico Juan Bautista Peña",
                            StartDate = 2013,
                            EndDate = 2007,
                            Finalized = true,
                        },
                        new Education
                        {
                            Id = 2,
                            PersonId = 1,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            Degree = "Tecnicatura Universitaria en Desarrollo de Software",
                            Institution = "Universidad de Ezeiza",
                            StartDate = 2013,
                            Finalized = false,
                        },
                        new Education
                        {
                            Id = 3,
                            PersonId = 1,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            Degree = "Licenciatura en Seguridad Informática",
                            Institution = "Universidad Siglo XXI",
                            StartDate = 2023,
                            EndDate = 2026,
                            Finalized = false
                        }
                    },

                Languages = new List<Language>
                    {
                        new Language { Id = 1, PersonId = 1, Name = "Español", Level = Level.Native },
                        new Language { Id = 2, PersonId = 1, Name = "Inglés", Level = Level.UpperIntermediate }
                    },

                Technologies = new List<Technology>
                    {
                        new Technology { Id = 1, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "C#", Type = Entities.Type.Language },
                        new Technology { Id = 2, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "JavaScript", Type = Entities.Type.Language  },
                        new Technology { Id = 3, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Sql", Type = Entities.Type.Language },
                        new Technology { Id = 4, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "TypeScript", Type = Entities.Type.Language },

                        new Technology { Id = 5, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "GitHub", Type = Entities.Type.ToolPlatform  },
                        new Technology { Id = 6, PersonId = 1, CreatedDate= DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Azure Cloud", Type = Entities.Type.ToolPlatform },
                        new Technology { Id = 7, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Azure DevOps", Type = Entities.Type.ToolPlatform},

                        new Technology { Id = 8, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Pruebas unitarias", Type = Entities.Type.Methodology},
                        new Technology { Id = 9, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Pruebas integrales", Type = Entities.Type.Methodology},
                        new Technology { Id = 10, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Scrum", Type = Entities.Type.Methodology},
                        new Technology { Id = 11, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Microservicios", Type = Entities.Type.Methodology},

                        new Technology { Id = 12, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "HTML", Type = Entities.Type.WebTechnology},
                        new Technology { Id = 13, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "CSS", Type = Entities.Type.WebTechnology},
                        new Technology { Id = 14, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Ajax", Type = Entities.Type.WebTechnology},

                        new Technology { Id = 15, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "ASP.Net Core 6, 7 y 8", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 16, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "ASP.Net Core MVC", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 17, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Razor", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 18, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "JQuery", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 19, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Angular", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 20, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Boostrap", Type = Entities.Type.FrameworkLibrary},
                        new Technology { Id = 21, PersonId = 1, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow, TechnologyName = "Node Js.", Type = Entities.Type.FrameworkLibrary},
                    },


                WorkExperiences = new List<WorkExperience>
                    {
                        new WorkExperience
                        {
                            Id = 3,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            PersonId = 1,
                            Company = "Libercam",
                            Role = "Desarrollador Backend .Net",
                            Description = $"Me desempeño como FullStack Developer, aplicando store procedure dentro de las consultas de SQL, la cual son consumidas " +
                            $"por una API Rest con microservicios personalizada para la empresa. Dentro de la capa frontend, trabajo con ASP.Net Core MVC, " +
                            $"haciendo la página reactiva a través de Ajax, Jquery y JavaScript. La API, los controladores y modelos son diseñados por ASP.Net Core 6.",
                            StartDate = new DateTime(2025, 1, 15),
                        },
                        new WorkExperience
                        {
                            Id = 2,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            PersonId = 1,
                            Company = "NetKel",
                            Role = "Desarrollador FullStack .Net/Angular",
                            Description = $"Me desempeñé como FullStack Developer, contribuyendo al desarrollo de nuevas funcionalidades y la resolución de bugs" +
                            $" para el proyecto AYSA. Implemento principios de diseño SOLID en el backend y trabajo con un stack tecnológico moderno que incluye C#, " +
                            $"ASP.Net Core 6, Azure DevOps, SQL, y Angular 14, asegurando la estabilidad, escalabilidad y mantenibilidad del sistema. Colaboro en equipos " +
                            $"multidisciplinarios, aplicando metodologías ágiles para impulsar la mejora continua del producto mediante procesos iterativos.",
                            StartDate = new DateTime(2024, 4, 1),
                            EndDate = new DateTime(2024, 12, 31)
                        },
                        new WorkExperience
                        {
                            Id = 1,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow,
                            PersonId = 1,
                            Company = "The Flock",
                            Role = "Desarrollador Backend .Net",
                            Description = $"Me desempeñé como Backend Developer, en el desarrollo de la capa de Backend de una plataforma web con tecnologías como C#, " +
                            $"ASP.Net Core (versiones 6, 7 y 8), MVC ASP.Net Core, Razor, SQL, y herramientas web como HTML, CSS, JavaScript y JQuery.\r\n" +
                            $"Implementé metodologías ágiles SCRUM para optimizar los flujos de trabajo y asegurar la calidad del producto. Además, integré el sistema" +
                            $" con diversas APIs externas, incluyendo Auth0, SendGrid, DocuSign, Azure, Affinda, OpenAI, y Bootstrap, mejorando significativamente la " +
                            $"funcionalidad y experiencia del usuario.\r\nAdemás brindé soporte en el entorno Frontend utilizando la tecnología de React JS, Node JS y Typescript.\r\n" +
                            $"En el proyecto CUX, trabajé en el desarrollo de un asistente de inteligencia artificial diseñado para brindar apoyo emocional al usuario final. " +
                            $"Implementé la integración con OpenAI, desarrollando un sistema de chat basado en prompts dinámicos y personalizados para ofrecer una experiencia " +
                            $"interactiva y adaptable.",
                            StartDate = new DateTime(2022, 3, 01),
                            EndDate = new DateTime(2024, 02, 28)
                        },
                }

            };
            db.Add(person);

            foreach (var cert in person.Certifications)
                db.Add(cert);

            foreach (var edu in person.Educations)
                db.Add(edu);

            foreach (var tech in person.Technologies)
                db.Add(tech);

            foreach (var job in person.WorkExperiences)
                db.Add(job);

            foreach (var lang in person.Languages)
                db.Add(lang);
        }
    }
}