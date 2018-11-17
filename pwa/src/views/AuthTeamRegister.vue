<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col">
				<div class="row text-center">
					<div class="col-auto mx-auto pt-5">
						<h3 class="text-light">
							<img src="/img/logo.png" width="30" class="mb-2 mr-3" />
							<small>Be Your Best</small>
						</h3>
						<h1 class="text-light">
							{{ $route.params.name }}
						</h1>
						<div class="smallDividerBlock"></div>
					</div>
				</div>
				<div class="row text-white">
					<div class="col">
						<div class="form-group mt-5">
							<label>
								EMAIL
							</label>
							<input type="text" class="form-control"/>
						</div>
						<div class="form-group mt-3 mb-5">
							<label>
								PASSWORD
							</label>
							<input type="password" class="form-control"/>
						</div>
						<button class="btn btn-primary" v-on:click="registerUser()">
							SIGN IN
						</button>

						<p class="mb-0 mt-4">
							Already have an account in this team?
						</p>
						<router-link :to="{ path: '/Auth/Team/' + $route.params.name + '/Login' }"
						tag="button"
						class="btn btn-link">
							LOGIN
						</router-link>

						<div class="smallDividerBlock mt-5"></div>
						<p class="text-justify mt-3 text-light">
							<small>
                                Administratorem danych osobowych jest grupa projektowa Tragic Bytes w składzie: Bartosz Bernaś, Marek Bubiak oraz Anna Bernaś. Projekt powstał na hackathonie organizowanym przez firmę Euvic, w dniach 16-17 listopada 2018 roku w Gliwicach. Proszę nie czytać dalszego tekstu, gdyż są to farmazony. Blaeo naio naosdoa anjioa 771293 383903 noab;al. Anabja. Bosajb as  ahifafia ahioaw 2820000 29928 28 nlabh abifasdihds lisdla hia rbrus abehdue ah. Mahuahbap ahuiab au huaibdhia huiahi.
                            </small>
						</p>
						<router-link to="/" tag="button" class="btn btn-sm btn-link">BACK TO HOME</router-link>
					</div>
				</div>
			</div>
		</div>
	</div>
</template>

<script>
import firebase from "firebase";
import { db } from "../db";

export default {
  data: () => {
    // userName: ''
    // userPasswd: ''
  },
  watch: {},
  methods: {
    registerUser: function() {
      this.$router.push(`/Team/Dashboard`);
    }
  }
};
</script>

<style scoped>
</style>
