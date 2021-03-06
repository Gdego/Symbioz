


















// Generated on 06/04/2015 18:44:45
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GuildKickRequestMessage : Message
{

public const ushort Id = 5887;
public override ushort MessageId
{
    get { return Id; }
}

public uint kickedId;
        

public GuildKickRequestMessage()
{
}

public GuildKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(kickedId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

kickedId = reader.ReadVarUhInt();
            if (kickedId < 0)
                throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0");
            

}


}


}