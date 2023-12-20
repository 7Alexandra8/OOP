using System;
using System.Collections.Generic;

    // Класс игры в покер
    public class PokerGame
    {
        private PokerBank bank;
        private Dealer dealer;
        private List<PlayerAccount> players;

        public PokerGame()
        {
            bank = new PokerBank();
            dealer = new Dealer();
            players = new List<PlayerAccount>();
        }

        // Метод для начала новой игры
        public void StartNewGame()
        {
            // Инициализация игроков и их счетов
            InitializePlayers();

            // Раздача карт игрокам
            DealCards();

            // Получение ставок от игроков
            GetBets();

            PlayerAccount winner = ChooseWinner();

            // Начисление выигрыша победителю
            if (winner != null)
            {
                bank.AwardWinner(winner,bank.GetTotalBetAmount(players));
            }
            else
            {
                // Начисление проигрыша игрокам, которые не смогли составить комбинацию
                
                foreach (PlayerAccount player in players)
                {
                    if (!player.HasValidCombination())
                    {
                        bank.DeductBet(player, player.GetBetAmount(1000));
                    }
                }
            }
        }

        // Метод для инициализации игроков и их счетов
        private void InitializePlayers()
        {
            PlayerAccount player1 = new PlayerAccount("Player 1", 1000);
            PlayerAccount player2 = new PlayerAccount("Player 2", 1000);
            PlayerAccount player3 = new PlayerAccount("Player 3", 1000);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
        }

        // Метод для раздачи карт игрокам
        private void DealCards()
        {
            List<Card> shuffledDeck = dealer.GetShuffledDeck();

            foreach (PlayerAccount player in players)
            {
                Card card = shuffledDeck[shuffledDeck.Count - 1];
                shuffledDeck.RemoveAt(shuffledDeck.Count - 1);
                player.TakeOneCard(card);
            }
        }

        // Метод для получения ставок от игроков
        private void GetBets()
        {
            foreach (PlayerAccount player in players)
            {
                int betAmount = player.GetBetAmount(1000);
                bool hasSufficientFunds = bank.HasSufficientFundsForBet(player, betAmount);

                if(hasSufficientFunds)
                {
                    bank.DeductBet(player, betAmount);
                    player.Withdraw(betAmount);
                }
            else
            {
                Console.WriteLine($"{player._name} does not have sufficient funds for the bet.");

            }
        }
        }

        // Метод для сравнения комбинаций карт у игроков и определения победителя
        private PlayerAccount ChooseWinner()
        {
            PlayerAccount winningPlayer = null;
            foreach (PlayerAccount player in players)
            {
                if (player.HasValidCombination())
                {
                    if (winningPlayer == null)
                    {
                        winningPlayer = player;
                    }

                    else
                    {
                        if (player.CompareCombinations(winningPlayer,dealer.TableCards) == 1)
                        {
                            winningPlayer = player;
                        }
                    }
                }
            }
            return winningPlayer;
        }
    }
