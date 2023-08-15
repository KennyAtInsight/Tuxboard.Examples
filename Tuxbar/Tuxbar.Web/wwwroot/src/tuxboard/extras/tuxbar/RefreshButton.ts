﻿import { Tuxbar } from "./Tuxbar";
import { TuxbarButton } from "./TuxbarButton";


export class RefreshButton extends TuxbarButton {

    private tuxbarRefreshButtonSelector: string = "#refresh-button";

    constructor(
        tuxBar: Tuxbar,
        changeLayoutSelector: string = null) {

        super(tuxBar, changeLayoutSelector);

        this.selector = changeLayoutSelector || this.tuxbarRefreshButtonSelector;

        const element = this.getDom();
        if (element) {
            element.addEventListener("click", (ev: Event) => {
                this.tuxBar.getTuxboard().refresh();
            }, false);
        }
    }

    getDom = () => this.tuxBar.getDom().querySelector(this.selector);
}
