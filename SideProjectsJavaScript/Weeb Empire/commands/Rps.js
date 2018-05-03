const rouletteScissors = [
  'I chose Rock... you lost!', 'I chose Paper... you won!', 'I chose Scissors... it\'s a tie!',
  'I chose Rock... you lost!', 'I chose Paper... you won!', 'I chose Scissors... it\'s a tie!',
  'I chose Rock... you lost!', 'I chose Paper... you won!', 'I chose Scissors... it\'s a tie!',
  'I chose Rock... you lost!', 'I chose Paper... you won!', 'I chose Scissors... it\'s a tie!',
  'I chose Rock... you lost!', 'I chose Paper... you won!', 'I chose Scissors... it\'s a tie!',
];
const rouletteRock = [
  'I chose Rock... it\'s a tie!', 'I chose Paper... you lost!', 'I chose Scissors... you won!',
  'I chose Rock... it\'s a tie!', 'I chose Paper... you lost!', 'I chose Scissors... you won!',
  'I chose Rock... it\'s a tie!', 'I chose Paper... you lost!', 'I chose Scissors... you won!',
  'I chose Rock... it\'s a tie!', 'I chose Paper... you lost!', 'I chose Scissors... you won!',
  'I chose Rock... it\'s a tie!', 'I chose Paper... you lost!', 'I chose Scissors... you won!',
];
const roulettePaper = [
  'I chose Rock... you won!', 'I chose Paper... it\'s a tie!', 'I chose Scissors... you lost!',
  'I chose Rock... you won!', 'I chose Paper... it\'s a tie!', 'I chose Scissors... you lost!',
  'I chose Rock... you won!', 'I chose Paper... it\'s a tie!', 'I chose Scissors... you lost!',
  'I chose Rock... you won!', 'I chose Paper... it\'s a tie!', 'I chose Scissors... you lost!',
  'I chose Rock... you won!', 'I chose Paper... it\'s a tie!', 'I chose Scissors... you lost!',
];
module.exports = {
  commands: [
    'rps',
    'rockpaperscissors',
  ],
  usage: 'rps <rock|paper|scissors>',
  description: 'Rock Paper Scissors ~~Gun~~!',
  category: 'Fun',
  execute: (client, message, args) => {
    if (!args[0]) return message.channel.send('Please choose a valid choice..... Rock, paper, or scissors...');
    if (args[0].toLowerCase() === 'scissors') {
      return message.channel.send(rouletteScissors[Math.floor(rouletteScissors.length * Math.random())]);
    } else if (args[0].toLowerCase() === 'rock') {
      return message.channel.send(rouletteRock[Math.floor(rouletteRock.length * Math.random())]);
    } else if (args[0].toLowerCase() === 'paper') {
      return message.channel.send(roulettePaper[Math.floor(roulettePaper.length * Math.random())]);
    } else {
      return message.channel.send('Please choose a valid choice..... Rock, paper, or scissors...');
    }
  },
};
