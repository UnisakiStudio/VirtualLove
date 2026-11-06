using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using jp.unisakistudio.posingsystem;

namespace jp.unisakistudio.virtuallove
{
    public class VirtualLove : PosingSystem
    {
        public override string AvatarReferenceProfileResourceName => "VirtualLoveAvatarReference";

        [HideInInspector]
        public bool isBoy;
    }
}