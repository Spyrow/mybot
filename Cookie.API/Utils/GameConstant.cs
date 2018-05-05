﻿using Cookie.API.Protocol.Enums;

namespace Cookie.API.Utils
{
    public static class GameConstant
    {
        public const byte Major = 2;
        public const byte Minor = 46;
        public const byte Release = 14;
        public const int Revision = 3;
        public const byte Patch = 0;
        public const byte BuildType = (byte) BuildTypeEnum.RELEASE;
        public const byte Install = (byte) ClientInstallTypeEnum.CLIENT_BUNDLE;
        public const byte Technology = (byte) ClientTechnologyEnum.CLIENT_AIR;
    }
}