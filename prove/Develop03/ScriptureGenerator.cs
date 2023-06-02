using System;

public class ScriptureGenerator
{
    List<string> _scriptures = new List<string>
    { 
        "Genesis 39:9","There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?",
        "Moses 1:39","For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.",
        "Psalm 24:4","He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.",
        "Malachi 4:6","And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.",
        "1 Corithians 6:20","For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's.",
        "John 14:15","If ye love me, keep my commandments.",
        "Hebrews 12:9","Furthermore we have had fathers of our flesh which corrected us, and we gave them reverence: shall we not much rather be in subjection unto the Father of spirits, and live?",
        "James 1:5","If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.",
        "2 Nephi 32:3","Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.",
        "Mosiah 2:17","And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
        "Alma 32:21","And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.",
        "Moroni 7:41","And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise.",
        "D&C 4:7","Ask and ye shall recieve; knock and it shall be opened unto you. Amen.",
        "D&C 8:3","Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.",
        "D&C 25:13","Wherefore, lift up thy heart and rejoice, and cleave unto the covenants which thou hast made.",
        "D&C 82:10","I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."
    };

    private Random rnd = new Random();
    private string _words;
    private string _reference;

    public string GenerateScripture()
    {
        int index = rnd.Next(_scriptures.Count-1);

        if (index % 2 == 0)
        {
            _words = _scriptures[index + 1];
            _reference = _scriptures[index];
        }
        
        else
        {
            _words = _scriptures[index];
            _reference = _scriptures[index - 1];
        }
        return $"{_words}";
    }

    public string GenerateChapter()
    {
        return $"{_reference}";
    }

}