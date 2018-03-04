
<a href="?id=0">Add item</a>
<? foreach ($LIST as $row): ?>
<li><a href="?id=<?=$row['last_name']?>"><?=$row['first_name']?></a>
<? endforeach ?>