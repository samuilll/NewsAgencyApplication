using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using New.Models;

namespace News.Repository
{
    internal sealed class Configuration : DbMigrationsConfiguration<NewsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            // TODO: Remove in production
            this.AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(NewsDbContext context)
        {
            if (!context.Articles.Any())
            {
                List<Category> categories = new List<Category>()
                {
                    new Category()
                    {
                        Name = "Sport"
                    },
                    new Category()
                    {
                        Name = "RussianLiterature"
                    },
                    new Category()
                    {
                        Name = "Crime"
                    },
                    new Category()
                    {
                        Name = "Politics"
                    },
                    new Category()
                    {
                        Name = "History"
                    },
                    new Category()
                    {
                        Name = "Scinence"
                    },
                    new Category()
                    {
                        Name = "Children"
                    },
                    new Category()
                    {
                        Name = "Fun"
                    },
                    new Category()
                    {
                        Name = "Curiosities"
                    },
                    new Category()
                    {
                        Name = "Kitchen"
                    },
                    new Category()
                    {
                        Name = "Boring"
                    }
                };

                List<Author> authors = new List<Author>()
                {
                    new Author()
                    {
                         Username  = "Ivan",
                    },
                    new Author()
                    {
                        Username  = "Marina",
                    },new Author()
                    {
                        Username  = "Isabela",
                    },new Author()
                    {
                        Username  = "Penka",
                    },new Author()
                    {
                        Username  = "Mitro",
                    },new Author()
                    {
                        Username  = "Hristo",
                    },new Author()
                    {
                        Username  = "Tsvetanka",
                    },new Author()
                    {
                        Username  = "Magdalena",
                    },new Author()
                    {
                        Username  = "Bonka",
                    },new Author()
                    {
                        Username  = "Vasilen",
                    },new Author()
                    {
                        Username  = "Miro",
                    }
                };

                List<Like> likes = new List<Like>()
                {
                    new Like()
                    {
                        Value = authors[0].Username
                    },
                    new Like()
                    {
                        Value = authors[1].Username
                    },
                    new Like()
                    {
                        Value = authors[2].Username
                    },
                    new Like()
                    {
                        Value = authors[3].Username
                    },
                    new Like()
                    {
                        Value = authors[4].Username
                    },
                    new Like()
                    {
                        Value = authors[5].Username
                    },
                    new Like()
                    {
                        Value = authors[6].Username
                    },
                    new Like()
                    {
                        Value = authors[7].Username
                    },
                    new Like()
                    {
                        Value = authors[8].Username
                    },
                    new Like()
                    {
                        Value = authors[9].Username
                    },
                    new Like()
                    {
                        Value = authors[10].Username
                    }
                };

                List<Article> articles = new List<Article>()
                {
                    new Article()
                    {
                        Author = authors[0],
                        Category = categories[1],
                        Title = "Yesterday",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[3],
                            likes[4],
                            likes[5],
                            likes[6],
                            likes[7],
                            likes[8],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[5],
                        Category = categories[7],
                        Title = "Barcelona",
                        Content ="ounded as a Roman city, in the Middle Ages Barcelona became the capital of the County of Barcelona. After merging with the Kingdom of Aragon, Barcelona continued to be an important city in the Crown of Aragon as an economic and administrative centre of this Crown and the capital of the Principality of Catalonia. Barcelona has a rich cultural heritage and is today an important cultural centre and a major tourist destination. Particularly renowned are the architectural works of Antoni Gaudí and Lluís Domènech i Montaner, which have been designated UNESCO World Heritage Sites. The headquarters of the Union for the Mediterranean are located in Barcelona.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[3],
                            likes[4],
                            likes[5],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[3],
                        Category = categories[7],
                        Title = "80's",
                        Content ="The final decade of the Cold War opened with the US-Soviet confrontation continuing largely without any interruption. Superpower tensions escalated rapidly as President Reagan scrapped the policy of détente and adopted a new, much more aggressive stance on the Soviet Union. The world came perilously close to nuclear war for the first time since the Cuban Missile Crisis 20 years earlier, but the second half of the decade saw a dramatic easing of superpower tensions and ultimately the total collapse of Soviet communism.",
                        Likes = new List<Like>()
                        {
                            likes[1],
                            likes[3],
                            likes[6],
                            likes[8],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[8],
                        Category = categories[5],
                        Title = "Stella",
                        Content ="aStella is a Canadian wine grower and producer. It is located on the east bench of Osoyoos lake, British Columbia, only a few minutes from USA-Canada border. Southern Okanagan Valley is known for its many wineries because of its unique desert micro climate. In fact the Sonoran desert that starts in Mexico, ends some 20 kilometers after entering Canadian border.[1]"
                       +" It is the sister winery to Le Vieux Pin.[2] Both wineries are owned and operated by Enotecca Wineries and Resorts, a holding company owned by entrepreneurs Sean and Saeedeh Salem.",
                        Likes = new List<Like>()
                        {
                            likes[0],                        
                        }
                    },
                      new Article()
                    {
                        Author = authors[3],
                        Category = categories[6],
                        Title = "Bomb",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[4],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[2],
                        Category = categories[8],
                        Title = "LastYear",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[5],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[0],
                        Category = categories[1],
                        Title = "Tomorrow",
                        Content =
                            "y the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[3],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[0],
                        Category = categories[1],
                        Title = "CookedMeat",
                        Content =
                            "by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[3],
                            likes[6],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[4],
                        Category = categories[4],
                        Title = "Chikago Bulls Title",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[1],
                            likes[3],
                            likes[8],
                            likes[9],
                        }
                    },
                      new Article()
                    {
                        Author = authors[6],
                        Category = categories[2],
                        Title = "BeforeWar",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[3],
                            likes[4],
                            likes[5],
                            likes[6],
                            likes[7],
                            likes[8],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[1],
                        Category = categories[0],
                        Title = "Hi",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[6],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[4],
                        Category = categories[8],
                        Title = "Preferential Prices",
                        Content =
                            "le by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[0],
                            likes[1],
                            likes[3],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[0],
                        Category = categories[1],
                        Title = "Bau",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[6],
                            likes[7],
                            likes[8],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[2],
                        Category = categories[8],
                        Title = "CartingRace",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {
                            likes[1],
                            likes[3],
                            likes[4],
                            likes[8],
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[5],
                        Category = categories[5],
                        Title = "NO,no,no",
                        Content =
                            "\r\n\"Yesterday\"\r\nBeatles-singles-yesterday.jpg\r\nUS picture sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {                          
                            likes[9],
                            likes[10],
                        }
                    },
                      new Article()
                    {
                        Author = authors[2],
                        Category = categories[8],
                        Title = "Never",
                        Content =
                            " sleeve\r\nSingle by the Beatles\r\nfrom the album Help!\r\nB-side\t\"Act Naturally\"\r\nReleased\t\r\n13 September 1965 (US)\r\n08 March 1976 (UK)\r\nFormat\t7-inch single\r\nRecorded\t14 June 1965\r\nStudio\tEMI Studios, London\r\nGenre\tBaroque pop,[1] chamber pop[2]\r\nLength\t2:03\r\nLabel\tCapitol\r\nSongwriter(s)\tLennon–McCartney\r\nProducer(s)\tGeorge Martin\r\nThe Beatles US singles chronology\r\n\"Help!\" \r\n(1965)\t\"Yesterday\" \r\n(1965)\t\"Day Tripper\" / \"We Can Work It Out\"\r\n(1965)\r\nThe Beatles UK singles chronology\r\n\"Let It Be\"\r\n(1970)\t\"Yesterday\"\r\n(1976)\t\"Back in the U.S.S.R.\"\r\n(1976)\r\nAlternative cover\r\n1976 UK picture sleeve\r\n1976 UK picture sleeve\r\nAudio sample\r\nMENU0:00\r\nfilehelp\r\n\"Yesterday\" is a song by the English rock band the Beatles, written by Paul McCartney (credited to Lennon–McCartney), and first released on the album Help! in the United Kingdom in August 1965.\r\n\r\n\"Yesterday\", with the B-side \"Act Naturally\", was released as a single in the United States in September 1965. While it topped the American chart in October the song also hit the British top 10 in a cover version by Matt Monro. The song also appeared on the UK EP \"Yesterday\" in March 1966 and the Beatles\' US album Yesterday and Today, released in June 1966.\r\n\r\nMcCartney\'s vocal and acoustic guitar, together with a string quartet, essentially made for the first solo performance of the band. It remains popular today and, with more than 2,200 cover versions,[3] is one of the most covered songs in the history of recorded music.[note 1] \"Yesterday\" was voted the best song of the 20th century in a 1999 BBC Radio 2 poll of music experts and listeners and was also voted the No. 1 pop song of all time by MTV and Rolling Stone magazine the following year. In 1997, the song was inducted into the Grammy Hall of Fame. Broadcast Music Incorporated (BMI) asserts that it was performed over seven million times in the 20th century.[5]\r\n\r\n\"Yesterday\" is a melancholy ballad about the break-up of a relationship. The singer laments for yesterday when he and his love were together, before she left because of something he said. McCartney is the only member of the Beatles to appear on the recording. The final recording was so different from other works by the Beatles that the band members vetoed the release of the song as a single in the United Kingdom, although other artists were quick to do so. It was issued as a single in the US in September 1965 and later released as a single in the UK in 1976.",
                        Likes = new List<Like>()
                        {                         
                            likes[9],
                            likes[10],
                        }
                    }

                };

                foreach (Category category in categories)
                {
                    context.Categories.Add(category);
                }
                foreach (Author author in authors)
                {
                    context.Authors.Add(author);
                }


                foreach (var article in articles)
                {
                    if (article.Title.Length % 5 == 0)
                    {
                        article.CreatedOn = DateTime.ParseExact("11-05-2005", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (article.Title.Length % 4 == 0)
                    {
                        article.CreatedOn = DateTime.ParseExact("30-01-1991", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (article.Title.Length % 3 == 0)
                    {
                        article.CreatedOn = DateTime.ParseExact("12-08-2010", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    }
                    else if (article.Title.Length % 2 == 0)
                    {
                        article.CreatedOn = DateTime.ParseExact("23-10-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        article.CreatedOn = DateTime.UtcNow;
                    }
                }

                foreach (Article article in articles)
                {
                    context.Articles.Add(article);
                }

                context.SaveChanges();

                foreach (Article article in context.Articles)
                {
                    foreach (Like like in article.Likes)
                    {
                        like.ArticleId = article.Id;
                    }
                }

                context.SaveChanges();
            }
    
        }
    }
}
