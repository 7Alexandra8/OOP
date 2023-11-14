using System;
using System.Collections.Generic;

namespace Lab_3_Test
{
    // Класс, реализующий игру BlackJack
    public class BlackJackGame
    {
        private ICardDealer cardDealer;
        private Bank bank;

        public BlackJackGame(ICardDealer dealer, Bank bank)
        {
            cardDealer = dealer;
            this.bank = bank;
        }

        public void PlayGame(Account playerAccount, int betAmount)
        {
            if (!bank.HasSufficientFunds(playerAccount, betAmount))
            {
                Console.WriteLine("Insufficient funds to place bet.");
                return;
            }
            // Раздача карт игроку и дилеру 
            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();

            playerHand.Add(cardDealer.DealCard());
            playerHand.Add(cardDealer.DealCard());
            dealerHand.Add(cardDealer.DealCard());

            // Логика игры согласно правилам блэкджека 

            // Подсчет очков игрока и дилера 
            int playerPoints = CalculatePoints(playerHand);
            int dealerPoints = CalculatePoints(dealerHand);

            while (playerPoints < 21)
            {
                Console.WriteLine("Player's hand: ");
                foreach (Card card in playerHand)
                {
                    Console.WriteLine(card.Rank + " of " + card.Suit);
                }
                Console.WriteLine("Player's points: " + playerPoints);

                Console.WriteLine("Dealer's hand: ");
                Console.WriteLine(dealerHand[0].Rank + " of " + dealerHand[0].Suit);

                // Проверка, хочет ли игрок взять дополнительную карту 
                Console.WriteLine("Hit or stay? (h/s)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "h")
                {
                    // Игрок берет дополнительную карту 
                    playerHand.Add(cardDealer.DealCard());
                    playerPoints = CalculatePoints(playerHand);
                }
                else if (choice.ToLower() == "s")
                {
                    // Игрок останавливается, дилер продолжает ход 
                    while (dealerPoints < 17)
                    {
                        dealerHand.Add(cardDealer.DealCard());
                        dealerPoints = CalculatePoints(dealerHand);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'h' or 's'.");
                }
            }

            Console.WriteLine("Player's final hand: ");
            foreach (Card card in playerHand)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
            Console.WriteLine("Player's final points: " + playerPoints);

            Console.WriteLine("Dealer's final hand: ");
            foreach (Card card in dealerHand)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
            Console.WriteLine("Dealer's final points: " + dealerPoints);

            if (playerPoints > 21)
            {
                Console.WriteLine("Player busts. You lose!");
                bank.Withdraw(playerAccount, betAmount);
            }
            else if (dealerPoints > 21 || playerPoints > dealerPoints)
            {
                Console.WriteLine("Player wins!");
                bank.Deposit(playerAccount, betAmount);
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("Dealer wins. You lose!");
                bank.Withdraw(playerAccount, betAmount);
            }
        }

        private int CalculatePoints(List<Card> hand)
        {
            int points = 0;
            int numAces = 0;

            foreach (Card card in hand)
            {
                if (card.Rank == Rank.Ace)
                {
                    numAces++;
                }
                points += (int)card.Rank;
            }

            while (points > 21 && numAces > 0)
            {
                points -= 10;
                numAces--;
            }

            return points;
        }
    }
}