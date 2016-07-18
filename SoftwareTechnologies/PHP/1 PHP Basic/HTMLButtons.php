
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Primes</title>
</head>
<body>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            for ($i = 1; $i <= $num; $i++){
                echo "<button>$i</button>";
            }
        }
    ?>
    <form>
        <div>Number:</div><input type="number" name="num">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>