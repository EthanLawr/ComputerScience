/* eslint complexity: ["off"]*/
const snekfetch = require('snekfetch');

module.exports = {
  commands: [
    'cat',
  ],
  usage: 'cat <type> || cat help',
  description: 'Cats!',
  category: 'Fun',
  execute: (client, message, args) => {
    if (!args[0]) {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'caturday') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=caturday').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'hat' || args[0] === 'hats') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=hats').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'space') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=space').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'kitten' || args[0] === 'kittens') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=kittens').set('api_key', 'Mjk1MTI4')
      .then(message.channel.send('Sorry, this part of the command is currently broken... so have this instead!',
      new global.Discord.Attachment('./images/meow.gif')));
    } else
    if (args[0] === 'funny' || args[0] === 'meme') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=funny').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'sunglasses') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=sunglasses').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'boxes' || args[0] === 'box') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=boxes').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'ties' || args[0] === 'tie') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=ties').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'dream' || args[0] === 'bed') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=dream').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'sinks' || args[0] === 'sink') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=sinks').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else
    if (args[0] === 'clothes' || args[0] === 'clothing') {
      return snekfetch.get('http://thecatapi.com/api/images/get?format=src&type=gif,jpg,png&category=clothes').set('api_key', 'Mjk1MTI4')
      .then(r => message.channel.send(new global.Discord.Attachment(r.body)));
    } else { return message.channel.send('Pick a valid type of cat or whatever bruh'); }
  },
};
