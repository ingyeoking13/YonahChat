using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using YonahChat.Grpc.Messages;
using GGrpc=Grpc.Core;

namespace YonahChat.Server.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Port = 9000;
            var cacert = File.ReadAllText(@"ca.crt");
            var cert = File.ReadAllText("server.crt");
            var key = File.ReadAllText("server.key");
            var keypair = new KeyCertificatePair(cert, key);
            var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>
            {
                keypair
            }, cacert, false);


            GGrpc.Server server = new GGrpc.Server
            {
                Ports = { new ServerPort("127.0.0.1", Port, sslCredentials) },
                Services = { YonahChat.Grpc.Messages.ChatEntryRPC.BindService(new ChatEntryRPCService()) }
            };

            server.Start();
            Console.WriteLine("Starting server on Port" + Port);
            Console.WriteLine("Press any key to stop..");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }

    public class ChatEntryRPCService : ChatEntryRPC.ChatEntryRPCBase
    {
        public override async Task<ChatEntryListReply> SayChatEntry(ChatEntryListRequest request, ServerCallContext context)
        {
            Metadata md = context.RequestHeaders;
            foreach (var entry in md)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }

            return new ChatEntryListReply();
        }
    }
}
