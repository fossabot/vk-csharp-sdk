using Xunit;
using Vk.CSharp.Sdk.Global.Enums;

namespace Vk.CSharp.Sdk.Tests.Source
{
    public class EnumsTests
    {
        [Fact]
        public void UserRights_All()
        {
            var expected =
                + ConvertToInt(UserRights.Notify)
                + ConvertToInt(UserRights.Ads)
                + ConvertToInt(UserRights.Audio)
                + ConvertToInt(UserRights.Docs)
                + ConvertToInt(UserRights.Email)
                + ConvertToInt(UserRights.Friends)
                + ConvertToInt(UserRights.Groups)
                + ConvertToInt(UserRights.LinkControl)
                + ConvertToInt(UserRights.Messages)
                + ConvertToInt(UserRights.Notes)
                + ConvertToInt(UserRights.Notifications)
                + ConvertToInt(UserRights.Offline)
                + ConvertToInt(UserRights.Pages)
                + ConvertToInt(UserRights.Photos)
                + ConvertToInt(UserRights.Stats)
                + ConvertToInt(UserRights.Status)
                + ConvertToInt(UserRights.Stories)
                + ConvertToInt(UserRights.Video)
                + ConvertToInt(UserRights.Wall)
                + ConvertToInt(UserRights.Market);

            Assert.Equal(140492255, ConvertToInt(UserRights.All));
            Assert.Equal(expected, ConvertToInt(UserRights.All));
        }

        [Fact]
        public void CommunityRights_All()
        {
            var expected =
                + ConvertToInt(CommunityRights.AppWidget)
                + ConvertToInt(CommunityRights.Docs)
                + ConvertToInt(CommunityRights.Manage)
                + ConvertToInt(CommunityRights.Messages)
                + ConvertToInt(CommunityRights.Photos)
                + ConvertToInt(CommunityRights.Stories);

            Assert.Equal(397381, ConvertToInt(CommunityRights.All));
            Assert.Equal(expected, ConvertToInt(CommunityRights.All));
        }

        private static int ConvertToInt(UserRights rights) =>
            (int) rights;

        private static int ConvertToInt(CommunityRights rights) =>
            (int)rights;
    }
}