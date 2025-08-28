<?php
$members = [
    [
        "id" => "inna",
        "fullName" => "Inna Amor Serrano",
        "personality" => "Ambivert",
        "favorites" => [
            "Food" => "Sinigang",
            "Animal" => "Pomeranian Dog",
            "Movie/Series" => "Sherlock Holmes",
            "KDrama" => "The Smile Has Left Your Eyes",
            "KPop" => "GFRIEND",
            "Jpop" => "ADO, YAOSABI"
        ],
        "hobbies" => [
            "Reading Wattpad, manga, webtoons, physical books",
            "Listening to Classical Music",
            "Playing Badminton"
        ],
        "img" => "INNA.jpg",
        "social" => [
            "facebook" => "https://www.facebook.com/innaserrano02",
            "instagram" => "https://www.instagram.com/amorin_na/?hl=en",
            "github" => "https://github.com/innaserrano02"
        ],
        "leader" => true
    ],
    [
        "id" => "phoebe",
        "fullName" => "Phoebe Kaye Pontiñoza",
        "personality" => "Extrovert",
        "favorites" => [
            "Color" => "Lavender",
            "Bible Verse" => "Matthew 6:25",
            "Instrument" => "Kalimba",
            "Ice Cream Flavor" => "Vanilla",
            "Time of Day" => "Midnight"
        ],
        "hobbies" => ["Watching BL series","Reading books"],
        "img" => "PHOEBE.jpg",
        "social" => [
            "facebook" => "https://www.facebook.com/iamphoebekaye/",
            "instagram" => "https://www.instagram.com/iamphoebekaye/?hl=en",
            "github" => "https://github.com/PhoebeKaye"
        ]
    ],
    [
        "id" => "crisel",
        "fullName" => "Ma. Crisel Francisco",
        "personality" => "Introvert",
        "favorites" => [
            "Color" => "Violet",
            "Food" => "Kaldereta",
            "Artist" => "Taylor Swift",
            "Place" => "Switzerland",
            "Comfort Food" => "Ice Cream",
            "Season" => "Winter"
        ],
        "hobbies" => ["Reading","Writing","Drawing"],
        "img" => "CRISEL.jpg",
        "social" => [
            "facebook" => "https://www.facebook.com/kkuriseruuchi",
            "instagram" => "https://www.instagram.com/kuriseruu/?hl=en",
            "github" => "https://github.com/CriselUchi"
        ]
    ],
    [
        "id" => "resare",
        "fullName" => "Griselle Jane C. Resare",
        "personality" => "Introvert",
        "favorites" => [
            "Animal" => "Cats & Dogs",
            "Movie/Series" => "Twilight",
            "KPop" => "BTS",
            "Books" => "Rara Ravis & Alegria Girls Series",
            "Author" => "Jonaxx",
            "Food" => "Adobo"
        ],
        "hobbies" => ["Reading Wattpad stories","Playing volleyball & online games","Watching movies or series"],
        "img" => "resare.jpeg",
        "social" => [
            "facebook" => "https://www.facebook.com/share/1JmRsvxK1u/",
            "instagram" => "https://www.instagram.com/gj.r_sr/?hl=en",
            "github" => "https://github.com/Griselle-Resare"
        ]
    ]
];
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Criphingels Team Profiles</title>
<link href="https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@1,700&family=Theano+Didot&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">
<style>
<?php include "style.css"; ?>

.badge.introvert,
.badge.extrovert,
.badge.ambivert,
.badge.leader,
.badge.mood {
  background-color: #8B4513;
  color: #ffffff;
  padding: 4px 8px;
  border-radius: 12px;
  font-size: 0.85rem;
  font-weight: bold;
  text-shadow: none;
  transition: transform 0.2s ease;
  margin-right: 8px;
}

.badge.introvert:hover,
.badge.extrovert:hover,
.badge.ambivert:hover,
.badge.leader:hover,
.badge.mood:hover {
  transform: scale(1.05);
  cursor: pointer;
}

.profile-pic {
  width: 220px;
  height: 220px;
  border-radius: 50%;
  object-fit: cover;
}

.profile-info {
  margin-left: 50px;
}
</style>
</head>
<body>

<header class="navbar">
<div class="nav-container">
  <a href="#home" class="logo">Criphingels</a>
  <ul class="nav-links">
    <?php foreach ($members as $m): ?>
      <?php $names = explode(" ", $m['fullName']); ?>
      <li><a href="#<?= $m['id'] ?>"><?= mb_strtoupper($names[count($names)-1], 'UTF-8') ?></a></li>
    <?php endforeach; ?>
  </ul>
</div>
</header>

<main>
<section class="start-page fade-in" id="home">
  <div class="start-content">
    <h1 class="start-title">Welcome to Criphingels</h1>
    <p class="subtitle"><span class="typing">Our Little Corner of the Web</span></p>
  </div>
</section>

<?php foreach ($members as $member): ?>
<section class="profile-section fade-in" id="<?= $member['id'] ?>">
  <article class="profile-card">
    <img src="<?= $member['img'] ?>" alt="<?= $member['fullName'] ?>" class="profile-pic">
    <div class="profile-info">
      <h1><?= $member['fullName'] ?></h1>

      <?php if(isset($member['leader']) && $member['leader']): ?>
        <span class="badge leader">Team Leader</span>
      <?php endif; ?>

      <?php if($member['personality'] === "Introvert"): ?>
        <span class="badge introvert"><?= $member['personality'] ?></span>
      <?php else: ?>
        <span class="badge <?= strtolower($member['personality']) ?>"><?= $member['personality'] ?></span>
      <?php endif; ?>

      <?php
      // IF-ELSEIF-ELSE statement for initial mood
      $mood = "Happy"; // default
      if ($mood === "Happy"):
          $moodEmoji = "😊 Happy";
      elseif ($mood === "Neutral"):
          $moodEmoji = "😐 Neutral";
      elseif ($mood === "Sad"):
          $moodEmoji = "😢 Sad";
      else:
          $moodEmoji = "😡 Angry";
      endif;
      ?>
      <span class="badge mood" onclick="changeMood(this)"><?= $moodEmoji ?></span>

      <h2>Favorites</h2>
      <ul>
        <?php foreach ($member['favorites'] as $key => $val): ?>
          <li><?= $key ?>: <?= $val ?></li>
        <?php endforeach; ?>
      </ul>

      <h2>Hobbies</h2>
      <ul>
        <?php foreach ($member['hobbies'] as $h): ?>
          <li><?= $h ?></li>
        <?php endforeach; ?>
      </ul>
    </div>

    <div class="profile-social">
      <div class="heart-menu"><i class="fa-solid fa-heart"></i>
        <div class="social-links">
          <?php foreach ($member['social'] as $platform => $link): ?>
            <a href="<?= $link ?>" target="_blank"><i class="fab fa-<?= $platform ?>"></i></a>
          <?php endforeach; ?>
        </div>
      </div>
    </div>
  </article>
</section>
<?php endforeach; ?>
</main>

<button id="backToTop" class="fade-in">↑</button>

<footer class="fade-in">
<p>© 2025 Criphingels</p>
</footer>

<script>
function changeMood(el) {
  const moods = ["😊 Happy","😐 Neutral","😢 Sad","😡 Angry"];
  let current = moods.indexOf(el.textContent);
  switch(current) {
    case 0: el.textContent = moods[1]; break;
    case 1: el.textContent = moods[2]; break;
    case 2: el.textContent = moods[3]; break;
    default: el.textContent = moods[0]; break;
  }
}
<?php include "script.js"; ?>
</script>
</body>
</html>


