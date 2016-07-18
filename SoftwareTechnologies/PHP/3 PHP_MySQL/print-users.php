<?php
$mysqli = new mysqli('localhost', 'root', '', 'blog');
$mysqli->set_charset("utf8");

if ($mysqli->connect_errno)
    die('Cannot connect to MySQL');

$result = $mysqli->query('SELECT * FROM posts');
if (!$result)
    die('Cannot read posts table from MySQL');
if($result->num_rows>0){
    while ($row = $result->fetch_assoc()) {
        echo "Id:" . $row['post_id'] . "<br>"
            . "Title:" . htmlspecialchars($row['title']) . "<br>"
            . "Content:" . htmlspecialchars($row['content']) . "<br>"
            . "Date:" . $row['date'] . "<br>";
    }
}
else {
    echo "0 results";
}
?>
