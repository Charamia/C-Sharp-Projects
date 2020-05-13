namespace ProfileSaver
{

    using System.IO;

    internal class Program
    {
        private static void Main()
        {
            var profile = new UserProfile();
            profile.FirstName = "Elena";
            profile.LastName = "Shumanova";
            profile.Age = 10;


            Save(profile);

            var loaddedProfile = Load();
        }

        private static void Save(UserProfile profile)
        {
            var writer = new StreamWriter("data.txt");

            //FirstName Elena
            //LastName Shumanova

            using (writer)
            {
                var profileType = typeof(UserProfile);
                var profileProperties = profileType.GetProperties();

                foreach (var property in profileProperties)
                {
                    var attributes = property.GetCustomAttributes(typeof(SaveAttribute), false);

                    if (attributes.Length >= 1)
                    {
                        writer.WriteLine(property.Name + " " + property.GetValue(profile));
                    }
                }
            }
        }

        private static UserProfile Load()
        {
            var reader = new StreamReader("data.txt");

            var profile = new UserProfile();

            using (reader)
            {
                var profileType = typeof(UserProfile);

                var currentData = reader.ReadLine();

                while (!string.IsNullOrEmpty(currentData))
                {
                    var values = currentData.Split(' ');
                    var propertyName = values[0];
                    var propertyValue = values[1];

                    var property = profileType.GetProperty(propertyName);
                    property.SetValue(profile, propertyValue);

                    currentData = reader.ReadLine();
                }
            }

            return profile;
        }
    }

}