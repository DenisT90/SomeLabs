using System;
namespace VeeamLabs.Labs
{
	public class Base
	{
		public virtual string GetInfo() => "BaseClass";
	}

	public class BaseOverridden : Base
    {
		public override string GetInfo() => $"{base.GetInfo()} -> BaseOverridden";
	}

	public class BaseOverlap : Base
	{
		public new string GetInfo() => $"{base.GetInfo()} -> BaseOverlap";
	}
}

