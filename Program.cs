
using Nethereum.HdWallet;
using System.Diagnostics;
namespace EthereumWallet
{
    class Program
    {
        static void Main(string[] args)
        {
          //0. result => cypto ramdom private key for owner of wallet
          //hurt test spare where age vapor advice elder betray column scan measure police bacon auto dial diesel lesson that opinion memory speed another eye

          //1. use private key for get wallet
          var wallet = new Wallet("hurt test spare where age vapor advice elder betray column scan measure police bacon auto dial diesel lesson that opinion memory speed another eye","");
          var account = wallet.GetAccount(0);
          var mnemonic = string.Join(" ", wallet.Words); 
          //3. print wallet from private key
          Debug.WriteLine(account.Address);
          //result
          //0xFe8dC03EA6E8784C1f7BfB5Da508505609fE85C0
        }
    }
}
