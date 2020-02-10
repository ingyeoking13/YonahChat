using Grpc.Core;
using System;
using System.IO;
using static YonahChat.Grpc.Messages;

namespace YonahChat.Client.Main
{
    public class YonahChatClient
    {
        public YonahChatClient()
        {
            const int Port = 9000;
            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText(@"client.crt");
            var key = File.ReadAllText(@"client.key");
            var keyPair = new KeyCertificatePair(cert, key);
            SslCredentials creds = new SslCredentials(cacert, keyPair);

            string PCName = "DESKTOP-P3RVAH";
            var channel = new Channel(PCName, Port, creds);
            var client = new Grpc.Messages.ChatEntryRPC.ChatEntryRPCBase
            var reply = await client
            //var client = new YonahChat.Grpc.Messages.ChatEntryRPC();
        }
    }
}
