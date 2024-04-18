namespace TechStoreApp.Common;

public static class SeedConstants
{
	public static class User
	{
		public const string AdminRoleId = "2358dc72-4280-40da-8986-4cf0cb4988ea";
		public const string AdminId = "05cb6d59-1d3d-4759-bd33-2378d9d9e689";
	}

	public static class Category
	{
		public const string LaptopsId = "3547201b-8c7a-4aa2-897b-369fa4534b69";
		public const string SmartphonesId = "ba1d090f-6ef7-4b01-be30-70a20d5be211";
		public const string TabletsId = "8cd90d0c-b726-4ced-b629-33b396dfce33";
		public const string GamingConsolesId = "81513340-1e09-4ca7-b741-668620ecc295";
		public const string PCComponentsId = "3a251054-83a8-4724-a988-da08c92c2848";
		public const string AudioEquipmentId = "d43121d1-f658-4259-877c-b956bc56b9f4";
		public const string CamerasId = "8965005a-657a-48a0-9321-027e992812d5";
		public const string WearableTechnologyId = "44737fa6-ae6e-4671-86dd-b0359f7ca5a9";
		public const string NetworkingDevicesId = "bea012e5-c4e0-4361-991b-88f9bb514a37";

		public static string[] CategoryIds = [LaptopsId, SmartphonesId, TabletsId, GamingConsolesId, PCComponentsId, AudioEquipmentId, CamerasId, WearableTechnologyId, NetworkingDevicesId];
	}
}
