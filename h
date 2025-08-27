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

foreach ($members as $member) {
    echo '<section class="profile-section fade-in" id="'.$member['id'].'">';
    echo '<article class="profile-card">';
    echo '<img src="'.$member['img'].'" alt="'.$member['fullName'].'" class="profile-pic">';
    echo '<div class="profile-info">';
    echo '<h1>'.$member['fullName'].'</h1>';

    // Leader badge
    if (!empty($member['leader'])) {
        echo '<span class="badge leader">Team Leader</span>';
    }

    // Personality badge
    $badgeClass = ($member['personality'] == "Introvert") ? "introvert" : "extrovert";
    echo '<span class="badge '.$badgeClass.'">'.$member['personality'].'</span>';

    // Hobby message
    if (in_array("Reading", $member['hobbies'])) {
        echo '<p>Loves reading!</p>';
    } elseif (in_array("Playing Badminton", $member['hobbies'])) {
        echo '<p>Enjoys sports!</p>';
    } else {
        echo '<p>Has unique hobbies!</p>';
    }

    // Favorites list
    echo '<h2>Favorites</h2><ul>';
    foreach ($member['favorites'] as $key => $value) {
        echo '<li>'.$key.': '.$value.'</li>';
    }
    echo '</ul>';

    // Hobbies list
    echo '<h2>Hobbies</h2><ul>';
    foreach ($member['hobbies'] as $hobby) {
        echo '<li>'.$hobby.'</li>';
    }
    echo '</ul>';

    echo '</div>'; // profile-info

    // Social links
    echo '<div class="profile-social">';
    echo '<div class="heart-menu"><i class="fa-solid fa-heart"></i>';
    echo '<div class="social-links">';
    foreach ($member['social'] as $platform => $link) {
        echo '<a href="'.$link.'" target="_blank"><i class="fab fa-'.$platform.'"></i></a>';
    }
    echo '</div></div></div>';

    // Color-based greeting
    if (!empty($member['favorites']['Color'])) {
        switch ($member['favorites']['Color']) {
            case "Lavender":
                echo '<p style="margin-top:10px;">Hello, lavender lover!</p>';
                break;
            case "Violet":
                echo '<p style="margin-top:10px;">Violet vibes!</p>';
                break;
            default:
                echo '<p style="margin-top:10px;">Welcome to the Team Criphingles!</p>';
                break;
        }
    }

    echo '</article></section>';
}
?>
