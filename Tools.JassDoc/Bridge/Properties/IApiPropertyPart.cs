using Tools.JassDoc.Bridge;

namespace Tools.JassDoc.Bridge.Properties
{
	public interface IApiPropertyPart : IApiEntity
	{
		ApiProperty Parent { get; }
	}
}
