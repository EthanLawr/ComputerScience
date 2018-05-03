const roulette = [
  'Wow! A Blank! You are safe',
  'Oh no.... you were shot ',
  'A Blank! You are safe',
  'A Blank!! You are safe',
  'A Blank.. You are safe',
  'Blank... You are safe',
];
module.exports = {
  commands: [
    'roulette',
    'russianroulette',
    'rr',
  ],
  usage: 'roulette',
  description: 'Russian Roulette',
  category: 'Fun',
  execute: (client, message) => {
    message.channel.send(roulette[Math.floor(roulette.length * Math.random())]);
  },
};
