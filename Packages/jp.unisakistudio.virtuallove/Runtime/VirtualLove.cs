using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jp.unisakistudio.posingsystem;

namespace jp.unisakistudio.virtuallove
{
    public class VirtualLove : PosingSystem
    {
        [HideInInspector]
        public bool isVirtualLoveBoyLicensed = false;

        [HideInInspector]
        public bool isVirtualLoveGirlLicensed = false;

        [HideInInspector]
        public bool isBoy;
    }
}