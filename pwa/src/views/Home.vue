<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col">
				<img src="/img/logo.png" width="150" class="img-fluid mb-3" /><br/>
				<h1 class="mb-3 text-light">
					Be Your Best
				</h1>
				<div class="row">
					<div class="col-sm-10 col-md-6 col-lg-4 mx-auto">
						<router-link to="/Auth/Team/Find" tag="button" class="btn btn-primary btn-block mb-3">
							FIND YOUR TEAM
						</router-link>
					</div>
				</div>
				<div class="row">
					<div class="col-sm-10 col-md-6 col-lg-4 mx-auto">
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
