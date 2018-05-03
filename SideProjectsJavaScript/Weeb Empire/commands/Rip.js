module.exports = {
  commands: [
    'rip',
  ],
  usage: 'rip [args]',
  description: 'Gravestone with text!',
  category: 'Fun',
  execute: (client, message, args) => {
    const sstring = args.join(' ');
    const Tombstone = `http://www.tombstonebuilder.com/generate.php?top1=R.I.P&top3=${sstring}&top4=Hopes and Dreams`;
    if (sstring.length < 23) {
      message.channel.send(new global.Discord.Attachment(Tombstone, 'hi.png'));
    }
    if (sstring.length > 23) {
      message.channel.send('Please enter less than 23 characters to use this command...');
    }
  },
};
