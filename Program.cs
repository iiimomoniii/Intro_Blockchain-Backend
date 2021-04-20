
using Nethereum.HdWallet;
using System.Diagnostics;
namespace EthereumWallet
{
    class Program
    {
        static void Main(string[] args)
        {
          //create wallet account (HDWallet)
          //1. NBitcoin.Wordlist.English (random English alphabet)
          //2. NBitcoin.WordCount.TwentyFour (from 1. English alphabet In 24 digit for private key)
          var wallet = new Wallet(NBitcoin.Wordlist.English, NBitcoin.WordCount.TwentyFour);
          //3. create account and use private key from 2.
          var account = wallet.GetAccount(0);
          //4.remember account by wallet.wor
          var mnemonic = string.Join(" ", wallet.Words); 
          //print account address
          Debug.WriteLine(mnemonic);
      
        
        }
    }
}
