using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstCsFinalProject.Models;

namespace CodeFirstCsFinalProject.DAL
{
    public class EpisodeInitializer : DropCreateDatabaseIfModelChanges<EpisodeContext>
    {
        protected override void Seed(EpisodeContext context)
        {
            var episodes = new List<Episode>
            {
                new Episode{
                    EpisodeId =101,
                    Title ="The First Two",
                    Synopsis ="The one where everyone is introduced.",
                    Duration =22,
                    OrigionalAirDate =DateTime.Parse("2016-09-15")
                },
                new Episode{
                    EpisodeId =102,
                    Title ="The Second One",
                    Synopsis ="The one where the guys can't stop talking about The One.",
                    Duration =23,
                    OrigionalAirDate =DateTime.Parse("2016-09-22")
                },
                new Episode{
                    EpisodeId =103,
                    Title ="The Funny Third",
                    Synopsis ="The Third One joins the gang for good.",
                    Duration =21,
                    OrigionalAirDate =DateTime.Parse("2016-09-29")
                }
            };

            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();
        }
    }
}