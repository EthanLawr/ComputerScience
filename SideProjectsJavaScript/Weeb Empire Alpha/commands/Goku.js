module.exports = {
  commands: [
    'goku',
  ],
  usage: 'goku',
  description: 'Goku!',
  category: 'Fun',
  execute: (client, message) => {
    message.channel.send('<@392299545821970442> Goku!');
    global.Mordant.channels.get('429024934925172738').send('<@392299545821970442> Hey goku!');
    global.Mordant.channels.get('429024934925172738').send('<@392299545821970442> Hey goku!');
    return message.channel.send('<@392299545821970442> Goku ~lenny~');
  },
};
