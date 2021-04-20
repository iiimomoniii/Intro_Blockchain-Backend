
using Nethereum.HdWallet;
using Nethereum.Web3;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EthereumWallet
{
    class Program
    {
        //server 
        public static readonly string SERVER = "https://rinkeby.infura.io/v3/6be6a5e9cdb644cdb0ad99c77ae815e4";
        static async Task Main(string[] args)
        {
          var wallet = new Wallet("hurt test spare where age vapor advice elder betray column scan measure police bacon auto dial diesel lesson that opinion memory speed another eye","");
          var account = wallet.GetAccount(0);
          var mnemonic = string.Join(" ", wallet.Words); 
          Debug.WriteLine(account.Address);
          //6. call CheckBalance
          await CheckBalance(account.Address);
          //7. if function is correct will return result is => Balance : 0
        }
        //1. CheckBalance Method for check money in wallet
        public static async Task CheckBalance(string address){
            //2. network for Ethereum between client and server
            //3. require server Ex. infura.io (End point RINKEBY)
            var client = new Web3(SERVER);
            //4. check eth balance (return eth in wei)
            var ethBalance = await client.Eth.GetBalance.SendRequestAsync(address);
            //5. convert value wei to money
            var balance = Web3.Convert.FromWei(ethBalance.Value);
            //Result
            Debug.WriteLine($"Balance : {balance}");
            
        }
    }
}
