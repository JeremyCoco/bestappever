<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col text-justify">
				<router-link to="/Team/dashboard" tag="button" class="btn btn-sm btn-link">BACK TO DASHBOARD</router-link>
				<hr/>
				<h4 class="text-primary">
					Terms of use
				</h4>
				<p class="text-light">
					Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum luctus tincidunt mauris, at laoreet mi tempor non. Aenean euismod sapien suscipit ligula suscipit viverra. Vivamus sollicitudin turpis quis ligula mattis porttitor. Donec hendrerit eu elit at pretium. Nunc ut turpis fringilla urna fringilla mollis gravida nec nibh. Fusce dictum nunc eu erat laoreet euismod vel eget lectus. Mauris facilisis nisi nec erat ultrices, nec ornare ex congue. Phasellus at sapien at erat molestie sodales id sit amet diam. Mauris suscipit leo a est iaculis, mollis sagittis diam ullamcorper. Proin sed velit facilisis, tristique lorem vitae, efficitur risus. Etiam sed auctor ligula, a pellentesque ipsum.
				</p>
				<p class="text-light">
					Integer felis dui, egestas id ante id, pulvinar posuere leo. Nunc porttitor enim et metus convallis auctor. Nullam et ipsum et elit luctus commodo. Nulla facilisi. Nam eget condimentum purus, eu egestas ipsum. Maecenas molestie, erat eget vulputate vulputate, enim est elementum lacus, et accumsan nibh massa a enim. Etiam dapibus dui non porttitor hendrerit. Ut sit amet venenatis odio, eu volutpat ante. Nunc congue scelerisque dui sed convallis. Phasellus condimentum dignissim porttitor.
				</p>
				<p class="text-light">
					Aliquam pellentesque, ipsum a suscipit consequat, turpis mauris pharetra velit, sit amet tempus nisi elit eget dui. Nam bibendum vitae diam quis mollis. Mauris sit amet pretium ligula. Phasellus tristique, ipsum dapibus pharetra viverra, quam velit cursus ligula, id tristique sem urna quis quam. Cras sed volutpat libero. Nunc tristique tempor aliquam. Curabitur blandit nulla et tortor facilisis molestie. Sed euismod feugiat mi, vel interdum justo cursus vitae. Pellentesque vitae vehicula metus. Proin ut vulputate nisl. Donec efficitur viverra quam, nec cursus lacus semper id.
				</p>
				<p class="text-light">
					Donec arcu est, feugiat ut leo non, maximus pellentesque risus. In eget aliquam quam. Praesent fringilla eleifend turpis nec dictum. Nulla tortor nisi, vestibulum pellentesque vehicula non, tincidunt sed lectus. Integer eget posuere quam. Integer metus magna, scelerisque ac aliquet eget, vulputate at nisi. Duis tempus vitae lectus eget ultricies. Proin nec ultrices erat, at aliquam augue. Sed lorem nibh, malesuada sit amet urna nec, elementum ultricies tellus. Cras id ullamcorper urna, sed maximus risus. Sed gravida tristique dictum. Ut tempus ornare erat non consequat. Integer quis magna neque. Quisque fringilla nisl at tellus tincidunt efficitur.
				</p>
				<p class="text-light">
					Aliquam iaculis metus nisi, non vehicula sapien interdum sit amet. Vestibulum bibendum ullamcorper odio, rutrum faucibus erat. Phasellus condimentum metus ullamcorper sem faucibus, id ullamcorper nunc porta. Praesent rutrum risus metus, at ultricies odio feugiat sed. Sed imperdiet gravida dolor vitae lobortis. Cras iaculis mattis metus non sodales. Curabitur tristique orci ligula. Vestibulum congue commodo turpis, vel tristique nisl imperdiet vitae. Pellentesque aliquet justo tellus, nec viverra purus malesuada non.
				</p>
			</div>
		</div>
	</div>
</template>

<script>
export default {};
</script>

<style scoped>
</style>

<!--
	MAROS CZA TO ZROBIĆ NA JUSZ:
	1. Find Team ma szukać drużyny w liście drużyn na serwerze(na nie ma zwraca błąd)
	2. Create team ma tworzyć drużynę(jak już jest ma zwrócic błąd)
	3. Login ma logować do konta(sprawdza czy jest drużyna o danej nazwie i w niej user, jak nie ma to zwraca błąd)
	4. Register ma stwarzać nowe konto w drużynie(jak już istnieje, ma zwrócić błąd)
	5. Rejestracja ma jednocześnie logować do apki
	6. po logowaniu użytkownik trafia do ekranu dashboard.
-->
