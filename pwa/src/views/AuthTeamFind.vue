<template>
	<div class="container-fluid">
		<div class="row align-items-center screenContainer">
			<div class="col">
				<div class="row text-center">
					<div class="col-auto mx-auto pt-5">
						<h1 class="text-light">
							<img src="/img/logo.png" width="40" class="mb-2" />
							Be Your Best
						</h1>
						<div class="smallDividerBlock"></div>
					</div>
				</div>
				<div class="row text-white">
					<div class="col">
						<div class="form-group mt-5">
							<label>
								GROUP NAME
							</label>
							<input type="text" class="form-control" v-model="teamName" />
						</div>
						<router-link :to="{ path: '/Auth/Team/' + teamName + '/Login' }"
						tag="button"
						class="btn btn-primary">
							FIND
						</router-link>

						<p class="mb-0 mt-4">
							Can't find your team?
						</p>
						<router-link to="/Auth/Team/Create" tag="button" class="btn btn-link">CREATE NEW</router-link>

						<p class="text-secondary text-justify mt-5">
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
    return {
      teamName: ""
    };
  },
  mounted: function() {},
  watch: {
    teamName: function(val) {
      this.teamName = val;
    }
  }
};
</script>

<style scoped>
</style>
