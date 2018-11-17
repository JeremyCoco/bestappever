using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BestAppEver.ComputingEngine.Helpers
{
    public class FirebaseDatabaseHelper
    {
        public FirebaseDatabaseHelper(string baseURL)
        {
            this.RootNode = baseURL;
        }

        private string RootNode { get; set; }

        public FirebaseDatabaseHelper Node(string node)
        {
            if (node.Contains("/"))
            {
                throw new FormatException("Node must not contain '/', use NodePath instead.");
            }

            return new FirebaseDatabaseHelper(this.RootNode + '/' + node);
        }

        public FirebaseDatabaseHelper NodePath(string nodePath)
        {
            return new FirebaseDatabaseHelper(this.RootNode + '/' + nodePath);
        }

        public FirebaseResponse Get()
        {
            return new FirebaseRequest(HttpMethod.Get, this.RootNode).Execute();
        }

        public FirebaseResponse Put(string jsonData)
        {
            return new FirebaseRequest(HttpMethod.Put, this.RootNode, jsonData).Execute();
        }

        public FirebaseResponse Post(string jsonData)
        {
            return new FirebaseRequest(HttpMethod.Post, this.RootNode, jsonData).Execute();
        }

        public FirebaseResponse Patch(string jsonData)
        {
            return new FirebaseRequest(new HttpMethod("PATCH"), this.RootNode, jsonData).Execute();
        }

        public FirebaseResponse Delete()
        {
            return new FirebaseRequest(HttpMethod.Delete, this.RootNode).Execute();
        }

        public override string ToString()
        {
            return this.RootNode;
        }
    }
}
