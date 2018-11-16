<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col">
				<img src="/img/logo.png" width="150" class="img-fluid mb-3" /><br/>
				<h1 class="mb-3 text-light">
					Be Your Best
				</h1>
				<div class="row">
					<div class="col-6 mx-auto">
						<router-link to="/Auth/Team/Find" tag="button" class="btn btn-primary btn-block mb-3">
							FIND YOUR TEAM
						</router-link>
					</div>
				</div>
				<div class="row">
					<div class="col-6 mx-auto">
						<router-link to="/Auth/Team/Create" tag="button" class="btn btn-outline-primary btn-block">
							CREATE NEW TEAM
						</router-link>
					</div>
				</div>
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
