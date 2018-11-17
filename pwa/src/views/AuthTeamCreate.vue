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
							<input type="text" class="form-control" v-model="teamName"/>
						</div>
						<button @click="createTeam(teamName)" class="btn btn-primary">CREATE</button>

						<p class="mb-0 mt-4">
							Already have a team?
						</p>
						<router-link to="/Auth/Team/Find" tag="button" class="btn btn-link">FIND IT</router-link>

						<div class="smallDividerBlock mt-5"></div>
						<p class="text-justify mt-3 text-light">
							<small>
							Administratorem danych osobowych w celu porównywania ofert Towarzystw Ubezpieczeniowych jest Bank Spółdzielczy w Zatorze z siedzibą w Zatorze 32 - 640 przy ulicy Różanej 2, którego akta rejestrowe są przechowywane w Sądzie Rejonowym dla Krakowa-Śródmieścia w Krakowie XII Wydział Gospodarczy Krajowego Rejestru Sądowego, wpisany do rejestru przedsiębiorców pod numerem KRS 0000143960, NIP: 5490011567, REGON: 000499850.Przy przetwarzaniu danych, w przypadku w którym wymagana jest zgoda, dane przetwarzane są do czasu wycofania przez Użytkownika zgody. W związku z przetwarzaniem danych osobowych Użytkownik ma prawo dostępu do danych, które są przechowywane, usunięcia i zmiany danych, w tym zaktualizowania swoich danych osobowych a także wniesienia sprzeciwu wobec przetwarzania danych osobowych z powodu szczególnej sytuacji, z wyłączeniem przypadku gdy jest to wymagane przepisami prawa.W celu realizacji powyższych praw, pytań lub uwag dotyczących sposobu przetwarzania danych osobowych należy kontaktować się pod adresem e-mail pomoc@codetown.eu. Istnieje możliwość wniesienia skargi do organu nadzorczego którym jest Prezes Urzędu Ochrony Danych Osobowych. Adres: Prezes Urzędu Ochrony Danych Osobowych, ul.Stawki 2, 00 - 193 Warszawa.
							</small>
						</p>
						<router-link to="/" tag="button" class="btn btn-sm btn-link">BACK TO HOME</router-link>
					</div>
				</div>
			</div>
		</div>
        <b-modal ref="teamExist" hide-footer title="Time not found">
            <div class="d-block text-center">
                <h3>This team name exist.</h3>
            </div>
            <b-btn class="mt-3" variant="outline-danger" block @click="hideModal">Close</b-btn>
        </b-modal>
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
  firebase: {
    teams: db.ref("teams")
  },
  methods: {
    createTeam(teamName) {
      let isTeam = false;
      let self = this;
      this.$firebaseRefs.teams
        .once("value")
        .then(function(snapshot) {
          snapshot.forEach(function(childSnapshot) {
            let childData = childSnapshot.val();
            if (childData.name === teamName) {
              self.$refs.teamExist.show();
              isTeam = true;
            }
          });
        })
        .then(function() {
          if (!isTeam) {
            self.$firebaseRefs.teams.push({
              name: teamName
            });
            this.$router.push(`/Auth/Team/${teamName}/Register`);
          }
        });
    },
    hideModal() {
      this.$refs.teamExist.hide();
    }
  }
};
</script>

<style scoped>
</style>
