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
							<input type="text" class="form-control" v-model="userName" />
						</div>
						<div class="form-group mt-3 mb-5">
							<label>
								PASSWORD
							</label>
							<input type="password" class="form-control" v-model="userPasswd" />
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

						<p class="text-secondary mt-5">
							<small>
							Administratorem danych osobowych w celu porównywania ofert Towarzystw Ubezpieczeniowych jest Bank Spółdzielczy w Zatorze z siedzibą w Zatorze 32 - 640 przy ulicy Różanej 2, którego akta rejestrowe są przechowywane w Sądzie Rejonowym dla Krakowa-Śródmieścia w Krakowie XII Wydział Gospodarczy Krajowego Rejestru Sądowego, wpisany do rejestru przedsiębiorców pod numerem KRS 0000143960, NIP: 5490011567, REGON: 000499850.Przy przetwarzaniu danych, w przypadku w którym wymagana jest zgoda, dane przetwarzane są do czasu wycofania przez Użytkownika zgody. W związku z przetwarzaniem danych osobowych Użytkownik ma prawo dostępu do danych, które są przechowywane, usunięcia i zmiany danych, w tym zaktualizowania swoich danych osobowych a także wniesienia sprzeciwu wobec przetwarzania danych osobowych z powodu szczególnej sytuacji, z wyłączeniem przypadku gdy jest to wymagane przepisami prawa.W celu realizacji powyższych praw, pytań lub uwag dotyczących sposobu przetwarzania danych osobowych należy kontaktować się pod adresem e-mail pomoc@codetown.eu. Istnieje możliwość wniesienia skargi do organu nadzorczego którym jest Prezes Urzędu Ochrony Danych Osobowych. Adres: Prezes Urzędu Ochrony Danych Osobowych, ul.Stawki 2, 00 - 193 Warszawa.
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
			userName: ''
			userPasswd: ''
		},
		watch: {
	    },
	    methods: {
	    	registerUser: function() {
	    		console.log("mocked action: registerUser");
	    	}
	    }
	};
</script>

<style scoped>
</style>