
using Nethereum.HdWallet;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EthereumWallet
{
    class Program
    {
        public static readonly string SERVER = "https://rinkeby.infura.io/v3/6be6a5e9cdb644cdb0ad99c77ae815e4";
        static async Task Main(string[] args)
        {
          //Case in wallet has 2 accounts
          //Transfer from account to receiverAccount
          var wallet = new Wallet("hurt test spare where age vapor advice elder betray column scan measure police bacon auto dial diesel lesson that opinion memory speed another eye","");
          // source account
          var account = wallet.GetAccount(0);
          //5. create destination account
          var receiverAccount = wallet.GetAccount(1);

        //   var mnemonic = string.Join(" ", wallet.Words); 
        //   Debug.WriteLine(account.Address);
        //   await CheckBalance(account.Address);

          //6. call function Transfer to Transfer 
          //1 is 1 eth from account to receiverAccount
          await Transfer(account, receiverAccount.Address, 1);
          //transection hash
          Debug.WriteLine(receiverAccount.Address);
          //7. check after transfered eth
          await CheckBalance(receiverAccount.Address);

          //result 
          //transection hash
          //0xf3d1c222642958f0fef22aac37b4cab308219bd3b222722f0bacc32a8048bcfb
          //receiverAccount
          //0x9F8054AE600E5959563F040a9De64216ca6d48f5
          //1 is eth from account
          //Balance : 1

        }
        public static async Task CheckBalance(string address){
            var client = new Web3(SERVER);
            var ethBalance = await client.Eth.GetBalance.SendRequestAsync(address);
            var balance = Web3.Convert.FromWei(ethBalance.Value);
            Debug.WriteLine($"Balance : {balance}");
            
        }
        //1. create function Transfer
        public static async Task Transfer(Account fromAccount, string receiverAddress, decimal amount){
            //2. client (pay gas for Transfer process)
            var client = new Web3(fromAccount, SERVER);
            //3. tranfers and wait confirm updated block of eth in sec time (if push more gas price will fast update block)
            var transaction = await client.Eth.GetEtherTransferService().TransferEtherAndWaitForReceiptAsync(receiverAddress, amount);
            //4. log number address for check transaction like slip payment
            Debug.WriteLine(transaction.TransactionHash);
        }
    }
}
